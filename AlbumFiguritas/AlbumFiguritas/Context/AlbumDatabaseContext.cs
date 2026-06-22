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
        public DbSet<SolicitudIntercambio> SolicitudesIntercambio { get; set; }

        //Esto crea un seed de datos para que la base de datos tenga información inicial. En este caso, se crean 6 usuarios (3 administradores y 3 usuarios por defecto) y 40 figuritas correspondientes a las selecciones de Argentina, Brasil, Francia e Inglaterra.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, NombreUsuario = "adminGabi", Email = "admingabi@test.com", Password = "123", Permiso = NivelPermiso.ADMINISTRADOR },
                new Usuario { Id = 2, NombreUsuario = "adminEze", Email = "admineze@test.com", Password = "123", Permiso = NivelPermiso.ADMINISTRADOR },
                new Usuario { Id = 3, NombreUsuario = "adminNico", Email = "adminnico@test.com", Password = "123", Permiso = NivelPermiso.ADMINISTRADOR },

                new Usuario { Id = 4, NombreUsuario = "defaultGabi", Email = "gabi@test.com", Password = "123", Permiso = NivelPermiso.USUARIO_DEFAULT },
                new Usuario { Id = 5, NombreUsuario = "defaultEze", Email = "eze@test.com", Password = "123", Permiso = NivelPermiso.USUARIO_DEFAULT },
                new Usuario { Id = 6, NombreUsuario = "defaultNico", Email = "nico@test.com", Password = "123", Permiso = NivelPermiso.USUARIO_DEFAULT }
            );

            var listaFiguritas = new List<Figurita>
            {
                // Argentina
                new Figurita { Id = 1, Numero = 1, NombreJugador = "Emiliano Martinez", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Emiliano Martinez.png" },
                new Figurita { Id = 2, Numero = 2, NombreJugador = "Nahuel Molina", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Nahuel Molina.png" },
                new Figurita { Id = 3, Numero = 3, NombreJugador = "Cristian Romero", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Cristian Romero.png" },
                new Figurita { Id = 4, Numero = 4, NombreJugador = "Nicolas Otamendi", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Nicolas Otamendi.png" },
                new Figurita { Id = 5, Numero = 5, NombreJugador = "Nicolas Tagliafico", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Nicolas Tagliafico.png" },
                new Figurita { Id = 6, Numero = 6, NombreJugador = "Rodrigo De Paul", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Rodrigo De Paul.png" },
                new Figurita { Id = 7, Numero = 7, NombreJugador = "Enzo Fernandez", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Enzo Fernandez.png" },
                new Figurita { Id = 8, Numero = 8, NombreJugador = "Alexis Mac Allister", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Alexis Mac Allister.png" },
                new Figurita { Id = 9, Numero = 9, NombreJugador = "Julian Alvarez", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Julian Alvarez.png" },
                new Figurita { Id = 10, Numero = 10, NombreJugador = "Lionel Messi", Seleccion = Pais.Argentina, UrlFotoJugador = "img/Lionel Messi.png" },

                // Brasil
                new Figurita { Id = 11, Numero = 11, NombreJugador = "Alisson Becker", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Alisson Becker.png" },
                new Figurita { Id = 12, Numero = 12, NombreJugador = "Bruno Guimaraes", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Bruno Guimaraes.png" },
                new Figurita { Id = 13, Numero = 13, NombreJugador = "Casemiro", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Casemiro.png" },
                new Figurita { Id = 14, Numero = 14, NombreJugador = "Danilo", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Danilo.png" },
                new Figurita { Id = 15, Numero = 15, NombreJugador = "Lucas Paqueta", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Lucas Paqueta.png" },
                new Figurita { Id = 16, Numero = 16, NombreJugador = "Marquinhos", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Marquinhos.png" },
                new Figurita { Id = 17, Numero = 17, NombreJugador = "Mateus Cunha", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Mateus Cunha.png" },
                new Figurita { Id = 18, Numero = 18, NombreJugador = "Raphinha", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Raphinha.png" },
                new Figurita { Id = 19, Numero = 19, NombreJugador = "Vinicius Junior", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Vinicius Junior.png" },
                new Figurita { Id = 20, Numero = 20, NombreJugador = "Wesley", Seleccion = Pais.Brasil, UrlFotoJugador = "img/Wesley.png" },

                // Francia
                new Figurita { Id = 21, Numero = 21, NombreJugador = "Aurelien Tchouameni", Seleccion = Pais.Francia, UrlFotoJugador = "img/Aurelien Tchouameni.png" },
                new Figurita { Id = 22, Numero = 22, NombreJugador = "Dayot Upamecano", Seleccion = Pais.Francia, UrlFotoJugador = "img/Dayot Upamecano.png" },
                new Figurita { Id = 23, Numero = 23, NombreJugador = "Desire Doue", Seleccion = Pais.Francia, UrlFotoJugador = "img/Desire Doue.png" },
                new Figurita { Id = 24, Numero = 24, NombreJugador = "Eduardo Camavinga", Seleccion = Pais.Francia, UrlFotoJugador = "img/Eduardo Camavinga.png" },
                new Figurita { Id = 25, Numero = 25, NombreJugador = "Ibrahima Konate", Seleccion = Pais.Francia, UrlFotoJugador = "img/Ibrahima Konate.png" },
                new Figurita { Id = 26, Numero = 26, NombreJugador = "Kingsley Coman", Seleccion = Pais.Francia, UrlFotoJugador = "img/Kingsley Koman.png" },
                new Figurita { Id = 27, Numero = 27, NombreJugador = "Kylian Mbappe", Seleccion = Pais.Francia, UrlFotoJugador = "img/Kylian Mbappe.png" },
                new Figurita { Id = 28, Numero = 28, NombreJugador = "Mike Maignan", Seleccion = Pais.Francia, UrlFotoJugador = "img/Mike Maignan.png" },
                new Figurita { Id = 29, Numero = 29, NombreJugador = "Ousmane Dembele", Seleccion = Pais.Francia, UrlFotoJugador = "img/Ousmane Dembele.png" },
                new Figurita { Id = 30, Numero = 30, NombreJugador = "Theo Hernandez", Seleccion = Pais.Francia, UrlFotoJugador = "img/Theo Hernandez.png" },

                // Inglaterra
                new Figurita { Id = 31, Numero = 31, NombreJugador = "Alexander Arnold", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Alexander Arnold.png" },
                new Figurita { Id = 32, Numero = 32, NombreJugador = "Declan Rice", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Declan Rice.png" },
                new Figurita { Id = 33, Numero = 33, NombreJugador = "Ezri Konsa", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Ezri Konsa.png" },
                new Figurita { Id = 34, Numero = 34, NombreJugador = "Harry Kane", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Harry Kane.png" },
                new Figurita { Id = 35, Numero = 35, NombreJugador = "John Stones", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/John Stones.png" },
                new Figurita { Id = 36, Numero = 36, NombreJugador = "Jordan Henderson", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Jordan Henderson.png" },
                new Figurita { Id = 37, Numero = 37, NombreJugador = "Jordan Pickford", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Jordan Pickford.png" },
                new Figurita { Id = 38, Numero = 38, NombreJugador = "Jude Bellingham", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Jude Bellingham.png" },
                new Figurita { Id = 39, Numero = 39, NombreJugador = "Phil Foden", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Phil Foden.png" },
                new Figurita { Id = 40, Numero = 40, NombreJugador = "Reece James", Seleccion = Pais.Inglaterra, UrlFotoJugador = "img/Reece James.png" },
            };

            modelBuilder.Entity<Figurita>().HasData(listaFiguritas);

            // Configuración de relaciones para evitar múltiples Cascade Delete
            modelBuilder.Entity<SolicitudIntercambio>()
                .HasOne(s => s.FiguritaOfrecida)
                .WithMany()
                .HasForeignKey(s => s.FiguritaOfrecidaId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SolicitudIntercambio>()
                .HasOne(s => s.FiguritaSolicitada)
                .WithMany()
                .HasForeignKey(s => s.FiguritaSolicitadaId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
