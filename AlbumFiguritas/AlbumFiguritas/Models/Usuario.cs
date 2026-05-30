namespace AlbumFiguritas.Models
{
    public class Usuario
    {
        // Temporalmente se utilizan tipos anulables (?) para evitar warnings durante el modelado inicial.
        // Más adelante se evaluará qué campos deben ser obligatorios e inicializados.
        
        // DIFERENCIA:
        // Usar "?" cuando el atributo pueda no tener valor (null) 
        // Inicializar cuando el atributo deba existir obligatoriamente en el sistema y no debería ser null.

        public int Id { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public NivelPermiso Permiso { get; set; }

        public List<UsuarioFigurita> MiAlbum { get; set; } = new List<UsuarioFigurita>();

    }
}
