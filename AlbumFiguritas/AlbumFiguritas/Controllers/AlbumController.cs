using Microsoft.AspNetCore.Mvc;

namespace AlbumFiguritas.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Gestion()
        {
            return View();
        }

        public IActionResult MiAlbum()
        {
            return View();
        }
    }
}
