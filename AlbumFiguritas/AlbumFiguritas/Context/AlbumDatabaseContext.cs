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
                new Figurita { Id = 1, Numero = 1, NombreJugador = "Emiliano Martinez", Seleccion = Pais.Argentina },
                new Figurita { Id = 2, Numero = 2, NombreJugador = "Nahuel Molina", Seleccion = Pais.Argentina },
                new Figurita { Id = 3, Numero = 3, NombreJugador = "Cristian Romero", Seleccion = Pais.Argentina },
                new Figurita { Id = 4, Numero = 4, NombreJugador = "Nicolas Otamendi", Seleccion = Pais.Argentina },
                new Figurita { Id = 5, Numero = 5, NombreJugador = "Nicolas Tagliafico", Seleccion = Pais.Argentina },
                new Figurita { Id = 6, Numero = 6, NombreJugador = "Rodrigo De Paul", Seleccion = Pais.Argentina },
                new Figurita { Id = 7, Numero = 7, NombreJugador = "Enzo Fernandez", Seleccion = Pais.Argentina },
                new Figurita { Id = 8, Numero = 8, NombreJugador = "Alexis Mac Allister", Seleccion = Pais.Argentina },
                new Figurita { Id = 9, Numero = 9, NombreJugador = "Julian Alvarez", Seleccion = Pais.Argentina },
                new Figurita { Id = 10, Numero = 10, NombreJugador = "Lionel Messi", Seleccion = Pais.Argentina },

                // Brasil
                new Figurita { Id = 11, Numero = 11, NombreJugador = "Alisson Becker", Seleccion = Pais.Brasil },
                new Figurita { Id = 12, Numero = 12, NombreJugador = "Danilo", Seleccion = Pais.Brasil },
                new Figurita { Id = 13, Numero = 13, NombreJugador = "Marquinhos", Seleccion = Pais.Brasil },
                new Figurita { Id = 14, Numero = 14, NombreJugador = "Thiago Silva", Seleccion = Pais.Brasil },
                new Figurita { Id = 15, Numero = 15, NombreJugador = "Casemiro", Seleccion = Pais.Brasil },
                new Figurita { Id = 16, Numero = 16, NombreJugador = "Lucas Paqueta", Seleccion = Pais.Brasil },
                new Figurita { Id = 17, Numero = 17, NombreJugador = "Neymar Jr", Seleccion = Pais.Brasil },
                new Figurita { Id = 18, Numero = 18, NombreJugador = "Vinicius Jr", Seleccion = Pais.Brasil },
                new Figurita { Id = 19, Numero = 19, NombreJugador = "Richarlison", Seleccion = Pais.Brasil },
                new Figurita { Id = 20, Numero = 20, NombreJugador = "Raphinha", Seleccion = Pais.Brasil },

                // Francia
                new Figurita { Id = 21, Numero = 21, NombreJugador = "Hugo Lloris", Seleccion = Pais.Francia },
                new Figurita { Id = 22, Numero = 22, NombreJugador = "Raphael Varane", Seleccion = Pais.Francia },
                new Figurita { Id = 23, Numero = 23, NombreJugador = "Dayot Upamecano", Seleccion = Pais.Francia },
                new Figurita { Id = 24, Numero = 24, NombreJugador = "Theo Hernandez", Seleccion = Pais.Francia },
                new Figurita { Id = 25, Numero = 25, NombreJugador = "Aurelien Tchouameni", Seleccion = Pais.Francia },
                new Figurita { Id = 26, Numero = 26, NombreJugador = "Adrien Rabiot", Seleccion = Pais.Francia },
                new Figurita { Id = 27, Numero = 27, NombreJugador = "Antoine Griezmann", Seleccion = Pais.Francia },
                new Figurita { Id = 28, Numero = 28, NombreJugador = "Ousmane Dembele", Seleccion = Pais.Francia },
                new Figurita { Id = 29, Numero = 29, NombreJugador = "Kylian Mbappe", Seleccion = Pais.Francia },
                new Figurita { Id = 30, Numero = 30, NombreJugador = "Olivier Giroud", Seleccion = Pais.Francia },

                // Inglaterra
                new Figurita { Id = 31, Numero = 31, NombreJugador = "Jordan Pickford", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 32, Numero = 32, NombreJugador = "Kyle Walker", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 33, Numero = 33, NombreJugador = "John Stones", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 34, Numero = 34, NombreJugador = "Harry Maguire", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 35, Numero = 35, NombreJugador = "Luke Shaw", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 36, Numero = 36, NombreJugador = "Declan Rice", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 37, Numero = 37, NombreJugador = "Jude Bellingham", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 38, Numero = 38, NombreJugador = "Bukayo Saka", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 39, Numero = 39, NombreJugador = "Phil Foden", Seleccion = Pais.Inglaterra },
                new Figurita { Id = 40, Numero = 40, NombreJugador = "Harry Kane", Seleccion = Pais.Inglaterra }
            };

            modelBuilder.Entity<Figurita>().HasData(listaFiguritas);
        }

    }
}
