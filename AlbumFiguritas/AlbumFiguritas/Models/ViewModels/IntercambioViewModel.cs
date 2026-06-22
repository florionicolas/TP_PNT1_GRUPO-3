using AlbumFiguritas.Models;

namespace AlbumFiguritas.Models.ViewModels
{
    // ViewModel utilizado por las vistas del módulo de intercambios.
    // Contiene las figuritas disponibles para crear solicitudes,
    // las listas de solicitudes activas y realizadas del usuario.
    public class IntercambioViewModel
    {
        // Figuritas que el usuario puede ofrecer (duplicadas)
        public List<Figurita> Repetidas { get; set; } = new List<Figurita>();

        // Figuritas que el usuario necesita (no tiene en su álbum)
        public List<Figurita> Faltantes { get; set; } = new List<Figurita>();

        // Solicitudes de intercambio que están pendientes
        public List<SolicitudIntercambio> SolicitudesActivas { get; set; } = new();

        // Solicitudes de intercambio que ya fueron concretadas
        public List<SolicitudIntercambio> SolicitudesRealizadas { get; set; } = new();
        
        // Solicitud que se está editando
        public SolicitudIntercambio? Solicitud { get; set; }

    }
}
