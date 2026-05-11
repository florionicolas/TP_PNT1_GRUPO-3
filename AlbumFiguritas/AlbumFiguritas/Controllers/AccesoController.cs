using Microsoft.AspNetCore.Mvc;

namespace AlbumFiguritas.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
