using AlbumFiguritas.Context;
using Microsoft.AspNetCore.Mvc;

namespace AlbumFiguritas.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumDatabaseContext _context;

        public AlbumController(AlbumDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Gestion()
        {
            var figuritas = _context.Figuritas.ToList();
            return View(figuritas);
        }

        public IActionResult MiAlbum()
        {
            return View();
        }
    }
}
