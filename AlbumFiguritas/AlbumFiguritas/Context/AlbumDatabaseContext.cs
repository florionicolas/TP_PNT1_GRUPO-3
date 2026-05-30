using Microsoft.EntityFrameworkCore;
using AlbumFiguritas.Models;

namespace AlbumFiguritas.Context
{
    public class AlbumDatabaseContext : DbContext
    {
        public AlbumDatabaseContext(DbContextOptions<AlbumDatabaseContext> options) : base(options)
        { }

        //Esto crea las tablas en la base de datos a partir de las clases que definimos como modelos. Cada DbSet representa una tabla.
        public DbSet<Figurita> Figuritas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioFigurita> UsuarioFiguritas { get; set; }
    }
}
