using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MagicVilla_API.Datos
{
    public class AplicationDbContext :DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Villa> villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
             new Villa()
             {
                 Id = 1,
                 Nombre = "Villa Real",
                 Detalle = "Detalle de la Villa",
                 ImagenUrl = "",
                 Ocupantes = 5,
                 MetrosCuadrados = 50,
                 Tarifa = 200,
                 Amenidad = "",
                 FechaCreacion = DateTime.Now,
                 FechaActualizacion = DateTime.Now
             },
             new Villa()
             {
                 Id = 2,
                 Nombre = "Villa Premiun",
                 Detalle = "Detalle de la Villa",
                 ImagenUrl = "",
                 Ocupantes = 10,
                 MetrosCuadrados = 100,
                 Tarifa = 500,
                 Amenidad = "",
                 FechaCreacion = DateTime.Now,
                 FechaActualizacion = DateTime.Now
             }
          );
        }

    }
}
