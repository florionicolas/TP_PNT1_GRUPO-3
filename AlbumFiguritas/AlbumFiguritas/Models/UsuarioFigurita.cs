

namespace AlbumFiguritas.Models

{
    public class UsuarioFigurita
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }

        public int FiguritaId { get; set; }

        public int Cantidad { get; set; }

        // PROPIEDADES DE NAVEGACIÓN (Para C# y Entity Framework)
        // Sirve para que el Include() pueda traer los datos cruzados.
        public Usuario? Usuario { get; set; }
        public Figurita? Figurita { get; set; }
    }
}
