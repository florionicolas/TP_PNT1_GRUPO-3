using AlbumFiguritas.Models;

namespace AlbumFiguritas.Models.ViewModels
{
    public class IntercambioViewModel
    {
        // Figuritas que el usuario puede ofrecer (duplicadas)
        public List<Figurita> Repetidas { get; set; } = new List<Figurita>();

        // Figuritas que el usuario necesita (no tiene en su álbum)
        public List<Figurita> Faltantes { get; set; } = new List<Figurita>();
    }
}
