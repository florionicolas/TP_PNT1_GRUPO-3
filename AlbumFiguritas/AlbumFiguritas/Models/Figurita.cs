namespace AlbumFiguritas.Models
{
    public class Figurita
    {
        // Temporalmente se utilizan tipos anulables (?) para evitar warnings durante el modelado inicial.
        // Más adelante se evaluará qué campos deben ser obligatorios e inicializados.
        // chequear si es public o private los atrib. -> Si, van public porque se van a mapear a una base de datos y se van a usar en vistas, etc.

        public int Id { get; set; }

        public int Numero { get; set; }

        public string? NombreJugador { get; set; }

        public string? Seleccion {  get; set; }

        public string? UrlFotoJugador { get; set; }

        public List<UsuarioFigurita> UsuariosPoseen { get; set; } = new List<UsuarioFigurita>();

    }
}
