using Microsoft.AspNetCore.Mvc;

namespace AlbumFiguritas.Controllers
{
    public class AccesoController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
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
            // Aquí iría la lógica para registrar al usuario en la base de datos
            // Por ejemplo: _userService.Register(username, password);
            return RedirectToAction("Registro");
        }
    }


}
