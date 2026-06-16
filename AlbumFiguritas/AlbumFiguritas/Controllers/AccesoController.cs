using AlbumFiguritas.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AlbumFiguritas.Controllers
{
    public class AccesoController : Controller
    {
        private readonly AlbumDatabaseContext _context;

        public AccesoController(AlbumDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var usuarioEncontrado = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (usuarioEncontrado != null)
            {

                //Guarda el Id del user logueado para identificarlo en funcionalidades como: Mi Album, Intercambios y Perfil.
                HttpContext.Session.SetInt32("UsuarioId",usuarioEncontrado.Id);
                HttpContext.Session.SetString("RolUsuario", usuarioEncontrado.Permiso.ToString());
                TempData["NombreUsuarioLogueado"] = usuarioEncontrado.NombreUsuario;

                if (usuarioEncontrado.Permiso.ToString() == "ADMINISTRADOR")
                { return RedirectToAction("Index", "Home");} 
                else
                { return RedirectToAction("MiAlbum", "Album");
                }


            }
            // Si las credenciales son incorrectas,
            // vuelve a mostrar la pantalla de Login.
            ModelState.AddModelError(
                string.Empty,
                "Email o contraseña incorrectos.");

            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string nombreUsuario, string email, string password, string confirmarPassword)
        {
            if (password != confirmarPassword)
            {
                ModelState.AddModelError(string.Empty, "Las contraseñas no coinciden.");
                return View();
            }
            // Acá va la lógica para registrar al usuario en la base de datos
            // Por ejemplo: _userService.Register(username, password);
            return RedirectToAction("Registro");
        }
        [HttpGet]
        public IActionResult Logout()
        {
            // Limpia todas las variables guardadas en la sesión actual (UsuarioId, RolUsuario, etc.)
            HttpContext.Session.Clear();

            // Redirige a la pantalla de Login (Asegurarse de poner el nombre correcto de tu controlador)
            return RedirectToAction("Login");
        }
    }


}
