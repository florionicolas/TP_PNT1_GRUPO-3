namespace AlbumFiguritas.Models
{
    public class SolicitudIntercambio
    {
        public int Id { get; set; }

        // Usuario que creó la solicitud de intercambio
        public int UsuarioId { get; set; }

        // Figurita que el usuario ofrece en el intercambio
        public int FiguritaOfrecidaId { get; set; }

        // Figurita que el usuario desea obtener
        public int FiguritaSolicitadaId { get; set; }

        // Estado de la solicitud (ACTIVA o REALIZADA)
        public EstadoSolicitud Estado { get; set; }

        // Fecha en la que se creó la solicitud
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Fecha en la que se concretó el intercambio (si ocurrió)
        public DateTime? FechaRealizacion { get; set; }

        // Navegación: usuario que creó la solicitud
        public Usuario Usuario { get; set; } = null!;

        // Navegación: figurita que se ofrece en el intercambio
        public Figurita FiguritaOfrecida { get; set; } = null!;

        // Navegación: figurita que se solicita en el intercambio
        public Figurita FiguritaSolicitada { get; set; } = null!;
    }
}
