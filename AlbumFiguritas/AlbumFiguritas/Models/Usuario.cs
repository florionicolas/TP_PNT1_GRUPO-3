namespace AlbumFiguritas.Models
{
    public class Usuario
    {
        // Temporalmente se utilizan tipos anulables (?) para evitar warnings durante el modelado inicial.
        // Más adelante se evaluará qué campos deben ser obligatorios e inicializados.
        
        // DIFERENCIA:
        // Usar "?" cuando el atributo pueda no tener valor (null) 
        // Inicializar cuando el atributo deba existir obligatoriamente en el sistema y no debería ser null.

        private int Id { get; set;  }

        private string? NombreUsuario { get; set; }

        private string? Email { get; set; }

        private string? Password { get; set; }

        private string? Rol {  get; set; }

    }
}
