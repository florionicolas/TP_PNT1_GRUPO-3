using AlbumFiguritas.Context;
using AlbumFiguritas.Models;
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

        public IActionResult Gestion(string? busqueda, string? seleccion)
        {
            var figuritas = _context.Figuritas.AsQueryable();

            // Filtra por nombre del jugador o número de figurita.
            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                figuritas = figuritas.Where(f =>
                    (f.NombreJugador ?? "").Contains(busqueda) || f.Numero.ToString().Contains(busqueda));
            }

            // Filtra por selección.
            if (!string.IsNullOrWhiteSpace(seleccion))
            {
                if (Enum.TryParse<Pais>(seleccion, out var paisSeleccionado))
                {
                    figuritas = figuritas.Where(f =>
                        f.Seleccion == paisSeleccionado);
                }
            }

            ViewBag.Busqueda = busqueda;
            ViewBag.Seleccion = seleccion;

            return View(figuritas.ToList());

        }

        public IActionResult MiAlbum()
        {
            return View();
        }
    }
}
