namespace AlbumFiguritas.Models
{
    public class UsuarioFigurita
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }

        public int FiguritaId { get; set; }

        public int Cantidad { get; set; }
        public EstadoFigurita Estado { get; set; }
    }
}
