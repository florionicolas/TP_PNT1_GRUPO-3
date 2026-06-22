using AlbumFiguritas.Context;
using AlbumFiguritas.Models;
using AlbumFiguritas.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlbumFiguritas.Controllers
{
    public class IntercambioController : Controller
    {
        private readonly AlbumDatabaseContext _context;

        public IntercambioController(AlbumDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Gestion()
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
                return RedirectToAction("Login", "Acceso");

            // REPETIDAS (cantidad > 1)
            var repetidas = _context.UsuarioFiguritas
                .Where(uf => uf.UsuarioId == usuarioId.Value && uf.Cantidad > 1)
                .Select(uf => uf.Figurita)
                .ToList();

            // FALTANTES (no posee la figurita)
            var idsUsuario = _context.UsuarioFiguritas
                .Where(uf => uf.UsuarioId == usuarioId.Value)
                .Select(uf => uf.FiguritaId)
                .ToList();

            var faltantes = _context.Figuritas
                .Where(f => !idsUsuario.Contains(f.Id))
                .ToList();

            // ARMADO DEL VIEWMODEL
            var model = new IntercambioViewModel
            {
                Repetidas = repetidas,
                Faltantes = faltantes,
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Crear(int figuritaOfrecidaId, int figuritaSolicitadaId)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
                return RedirectToAction("Login", "Acceso");

            // VALIDACIÓN 1: no puede ser la misma figurita
            if (figuritaOfrecidaId == figuritaSolicitadaId)
            {
                return RedirectToAction("Gestion");
            }

            // VALIDACIÓN 2: verificar que realmente la tenga repetida
            var tieneFigurita = _context.UsuarioFiguritas
                .Any(uf =>
                    uf.UsuarioId == usuarioId.Value &&
                    uf.FiguritaId == figuritaOfrecidaId &&
                    uf.Cantidad > 1);

            if (!tieneFigurita)
            {
                return RedirectToAction("Gestion");
            }

            // CREAR SOLICITUD
            var solicitud = new SolicitudIntercambio
            {
                UsuarioId = usuarioId.Value,
                FiguritaOfrecidaId = figuritaOfrecidaId,
                FiguritaSolicitadaId = figuritaSolicitadaId,
                Estado = EstadoSolicitud.ACTIVA,
                FechaCreacion = DateTime.Now
            };

            _context.SolicitudesIntercambio.Add(solicitud);
            _context.SaveChanges();

            return RedirectToAction("Gestion");
        }
        [HttpGet]
        public IActionResult Solicitudes()
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
                return RedirectToAction("Login", "Acceso");

            var solicitudes = _context.SolicitudesIntercambio
                .Where(s => s.UsuarioId == usuarioId.Value)
                .Include(s => s.FiguritaOfrecida)
                .Include(s => s.FiguritaSolicitada)
                .OrderByDescending(s => s.FechaCreacion)
                .ToList();

            return View(solicitudes);
        }
    }
}