namespace AlbumFiguritas.Models
{
    public class Figurita
    {
        // Temporalmente se utilizan tipos anulables (?) para evitar warnings durante el modelado inicial.
        // Más adelante se evaluará qué campos deben ser obligatorios e inicializados.
        // chequear si es public o private los atrib.

        private int Id { get; set; }

        private int Numero { get; set; }

        private string? NombreJugador { get; set; }

        private string? Seleccion {  get; set; }

        private string? UrlFotoJugador { get; set; }
        
    }
}
