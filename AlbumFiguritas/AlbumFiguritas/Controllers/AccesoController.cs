using AlbumFiguritas.Context;
using Microsoft.AspNetCore.Mvc;

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
                TempData["NombreUsuarioLogueado"] = usuarioEncontrado.NombreUsuario;
            }

            return RedirectToAction("Index", "Home");
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
            // Aquí iría la lógica para registrar al usuario en la base de datos
            // Por ejemplo: _userService.Register(username, password);
            return RedirectToAction("Registro");
        }
    }


}
