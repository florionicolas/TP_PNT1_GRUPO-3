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

            // Obtiene únicamente las solicitudes ACTIVAS del usuario
            var solicitudesActivas = _context.SolicitudesIntercambio
                .Where(s =>
                    s.UsuarioId == usuarioId.Value &&
                    s.Estado == EstadoSolicitud.ACTIVA)
                .Include(s => s.FiguritaOfrecida)
                .Include(s => s.FiguritaSolicitada)
                .OrderByDescending(s => s.FechaCreacion)
                .ToList();

            // Obtiene únicamente las solicitudes REALIZADAS del usuario
            var solicitudesRealizadas = _context.SolicitudesIntercambio
                .Where(s =>
                    s.UsuarioId == usuarioId.Value &&
                    s.Estado == EstadoSolicitud.REALIZADA)
                .Include(s => s.FiguritaOfrecida)
                .Include(s => s.FiguritaSolicitada)
                .OrderByDescending(s => s.FechaCreacion)
                .ToList();

            // Armado del ViewModel
            var model = new IntercambioViewModel
            {
                SolicitudesActivas = solicitudesActivas,
                SolicitudesRealizadas = solicitudesRealizadas
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
                return RedirectToAction("Login", "Acceso");

            // Buscar la solicitud a editar verificando que pertenezca al usuario logueado
            var solicitud = _context.SolicitudesIntercambio
                .FirstOrDefault(s =>
                    s.Id == id &&
                    s.UsuarioId == usuarioId.Value);

            if (solicitud == null)
                return RedirectToAction("Solicitudes");

            // Obtener las figuritas repetidas del usuario
            var repetidas = _context.UsuarioFiguritas
                .Where(uf => uf.UsuarioId == usuarioId.Value && uf.Cantidad > 1)
                .Select(uf => uf.Figurita)
                .ToList();

            // Obtener las figuritas faltantes del usuario
            var idsUsuario = _context.UsuarioFiguritas
                .Where(uf => uf.UsuarioId == usuarioId.Value)
                .Select(uf => uf.FiguritaId)
                .ToList();

            var faltantes = _context.Figuritas
                .Where(f => !idsUsuario.Contains(f.Id))
                .ToList();

            // Agregar las figuritas actualmente seleccionadas en la solicitud
            // para que también aparezcan en los select al editar
            if (!repetidas.Any(f => f.Id == solicitud.FiguritaOfrecidaId))
            {
                repetidas.Add(_context.Figuritas.Find(solicitud.FiguritaOfrecidaId)!);
            }

            if (!faltantes.Any(f => f.Id == solicitud.FiguritaSolicitadaId))
            {
                faltantes.Add(_context.Figuritas.Find(solicitud.FiguritaSolicitadaId)!);
            }

            // Reutilizamos el mismo ViewModel agregando la solicitud a editar
            var model = new IntercambioViewModel
            {
                Repetidas = repetidas,
                Faltantes = faltantes,
                Solicitud = solicitud
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult GuardarEdicion(int id, int figuritaOfrecidaId, int figuritaSolicitadaId)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
                return RedirectToAction("Login", "Acceso");

            // Buscar la solicitud del usuario
            var solicitud = _context.SolicitudesIntercambio
                .FirstOrDefault(s =>
                    s.Id == id &&
                    s.UsuarioId == usuarioId.Value);

            if (solicitud == null)
                return RedirectToAction("Solicitudes");

            // Validación: no puede ser la misma figurita
            if (figuritaOfrecidaId == figuritaSolicitadaId)
                return RedirectToAction("Editar", new { id });

            // Validación: debe seguir siendo válida la figurita ofrecida
            var tieneFigurita = _context.UsuarioFiguritas
                .Any(uf =>
                    uf.UsuarioId == usuarioId.Value &&
                    uf.FiguritaId == figuritaOfrecidaId &&
                    uf.Cantidad > 1);

            if (!tieneFigurita)
                return RedirectToAction("Editar", new { id });

            // ACTUALIZAR DATOS
            solicitud.FiguritaOfrecidaId = figuritaOfrecidaId;
            solicitud.FiguritaSolicitadaId = figuritaSolicitadaId;

            _context.SaveChanges();

            return RedirectToAction("Solicitudes");
        }

        // ELIMINAR UNA SOLICITUD DE INTERCAMBIO
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
                return RedirectToAction("Login", "Acceso");

            // Buscar la solicitud
            var solicitud = _context.SolicitudesIntercambio
                .FirstOrDefault(s =>
                    s.Id == id &&
                    s.UsuarioId == usuarioId.Value);

            // Si no existe o no pertenece al usuario, volver
            if (solicitud == null)
            {
                return RedirectToAction("Solicitudes");
            }

            // Eliminar la solicitud
            _context.SolicitudesIntercambio.Remove(solicitud);
            _context.SaveChanges();

            return RedirectToAction("Solicitudes");
        }

    }
}