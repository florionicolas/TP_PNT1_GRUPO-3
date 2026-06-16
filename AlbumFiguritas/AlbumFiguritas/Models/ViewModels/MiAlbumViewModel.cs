namespace AlbumFiguritas.Models.ViewModels
{
    public class MiAlbumViewModel
    {
        public int TotalObtenidas { get; set; }
        public int TotalFaltantes { get; set; }
        public int TotalRepetidas { get; set; }
        public double PorcentajeCompletado { get; set; }

        // Lista para la tabla inferior de MiAlbum
        public List<UsuarioFigurita>? AgregadasRecientemente { get; set; }
    }
}
