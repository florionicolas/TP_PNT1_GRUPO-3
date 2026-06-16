using AlbumFiguritas.Context;
using AlbumFiguritas.Models;
using AlbumFiguritas.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlbumFiguritas.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumDatabaseContext _context;

        public AlbumController(AlbumDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Gestion(string? busqueda, string? seleccion, string? estado)
        {
            // 1. CONTROL DE SEGURIDAD: Intentamos leer el ID desde la sesión
            int? usuarioIdLogueado = HttpContext.Session.GetInt32("UsuarioId");

            // Si el ID es nulo, significa que no pasó por el Login. Redirigimos a la pantalla de Acceso.
            if (usuarioIdLogueado == null)
            {
                return RedirectToAction("Login", "Acceso");
            }

            // 2. FILTRADO DINÁMICO (Nombre o Numero de Figurita): Empezamos con la consulta base y luego aplicamos filtros según los parámetros recibidos
            var figuritas = _context.Figuritas.AsQueryable();

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                figuritas = figuritas.Where(f =>
                    (f.NombreJugador ?? "").Contains(busqueda) || f.Numero.ToString().Contains(busqueda));
            }

            // 3. FILTRADO POR SELECCIÓN: Si se recibió un valor para "seleccion", intentamos convertirlo a enum y filtrar

            if (!string.IsNullOrWhiteSpace(seleccion))
            {
                if (Enum.TryParse<Pais>(seleccion, out var paisSeleccionado))
                {
                    figuritas = figuritas.Where(f => f.Seleccion == paisSeleccionado);
                }
            }

            // 4. FILTRO DE ESTADO (Calculado dinámicamente)
            if (!string.IsNullOrWhiteSpace(estado))
            {
                // Traemos las relaciones del usuario logueado
                var misRelaciones = _context.UsuarioFiguritas
                                            .Where(uf => uf.UsuarioId == usuarioIdLogueado.Value);

                if (estado == "FALTANTE")
                {
                    // Las que NO están en mi lista de relaciones
                    var misIds = misRelaciones.Select(uf => uf.FiguritaId).ToList();
                    figuritas = figuritas.Where(f => !misIds.Contains(f.Id));
                }
                else if (estado == "OBTENIDA")
                {
                    // Las que están en mi lista con Cantidad == 1
                    var obtenidasIds = misRelaciones.Where(uf => uf.Cantidad == 1).Select(uf => uf.FiguritaId).ToList();
                    figuritas = figuritas.Where(f => obtenidasIds.Contains(f.Id));
                }
                else if (estado == "DUPLICADA")
                {
                    // Las que están en mi lista con Cantidad > 1
                    var duplicadasIds = misRelaciones.Where(uf => uf.Cantidad > 1).Select(uf => uf.FiguritaId).ToList();
                    figuritas = figuritas.Where(f => duplicadasIds.Contains(f.Id));
                }
            }

            // 5. CONSULTA DINÁMICA: Usamos el ID de la sesión (.Value porque es un tipo Nullable)
            var diccionarioCantidades = _context.UsuarioFiguritas
                .Where(uf => uf.UsuarioId == usuarioIdLogueado.Value)
                .ToDictionary(uf => uf.FiguritaId, uf => uf.Cantidad);

            ViewBag.estado = estado;
            ViewBag.Busqueda = busqueda;
            ViewBag.Seleccion = seleccion;
            ViewBag.Cantidades = diccionarioCantidades;

            return View(figuritas.ToList());
        }

        [HttpPost]
        public IActionResult ActualizarCantidad(int figuritaId, int cambio, string? busqueda, string? seleccion)
        {
            // Validamos la sesión en el POST para evitar manipulaciones
            int? usuarioIdLogueado = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioIdLogueado == null)
            {
                return RedirectToAction("Login", "Acceso");
            }

            var registro = _context.UsuarioFiguritas
                .FirstOrDefault(uf => uf.UsuarioId == usuarioIdLogueado.Value && uf.FiguritaId == figuritaId);

            if (registro == null)
            {
                if (cambio > 0)
                {
                    _context.UsuarioFiguritas.Add(new UsuarioFigurita
                    {
                        UsuarioId = usuarioIdLogueado.Value,
                        FiguritaId = figuritaId,
                        Cantidad = 1

                    });
                }
            }
            else
            {
                registro.Cantidad += cambio;

                if (registro.Cantidad <= 0)
                {
                    _context.UsuarioFiguritas.Remove(registro);
                }
                else
                {
                    _context.UsuarioFiguritas.Update(registro);
                }
            }

            _context.SaveChanges();

            return RedirectToAction("Gestion", new { busqueda = busqueda, seleccion = seleccion });
        }

        [HttpGet]
        public IActionResult MiAlbum()
        {
            int? usuarioIdLogueado = HttpContext.Session.GetInt32("UsuarioId");
            if (usuarioIdLogueado == null) return RedirectToAction("Login", "Acceso");

            // 1. Obtener tamaño total del álbum (el catálogo completo)
            int totalFiguritasCatalogo = _context.Figuritas.Count();

            // 2. Obtener las figuritas que el usuario posee, cruzando con la tabla Figuritas (Include)
            var misFiguritas = _context.UsuarioFiguritas
                .Include(uf => uf.Figurita)
                .Where(uf => uf.UsuarioId == usuarioIdLogueado.Value)
                .ToList();

            // 3. Cálculos lógicos
            // Cuántos jugadores únicos tengo (cada fila es un jugador distinto)
            int unicasObtenidas = misFiguritas.Count;

            // Cuántas me faltan para completar el álbum
            int faltantes = totalFiguritasCatalogo - unicasObtenidas;

            // Cuántas figuritas físicas me sobran para intercambiar
            // (Ej: Si Cantidad es 1, sobra 0. Si Cantidad es 3, sobran 2)
            int repetidas = misFiguritas.Sum(uf => uf.Cantidad - 1);

            // Regla de 3 simple para el porcentaje (Se castea a double para tener precisión)
            double porcentaje = 0;
            if (totalFiguritasCatalogo > 0)
            {
                porcentaje = Math.Round(((double)unicasObtenidas / totalFiguritasCatalogo) * 100, 1);
            }

            // 4. Últimas 4 figuritas agregadas (Ordenamos por ID descendente)
            var recientes = misFiguritas
                .OrderByDescending(uf => uf.Id)
                .Take(4)
                .ToList();

            // 5. Empaquetar y enviar a la vista
            var viewModel = new MiAlbumViewModel
            {
                TotalObtenidas = unicasObtenidas,
                TotalFaltantes = faltantes,
                TotalRepetidas = repetidas,
                PorcentajeCompletado = porcentaje,
                AgregadasRecientemente = recientes
            };

            return View(viewModel);
        }
    }
}