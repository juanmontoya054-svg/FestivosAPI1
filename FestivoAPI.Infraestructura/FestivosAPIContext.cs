using Microsoft.EntityFrameworkCore;
using FestivosAPI.dominio;

namespace FestivoAPI.Infraestructura.Persistencia
{
    public class FestivosAPIContext : DbContext
    {
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Festivo> Festivo { get; set; }

        protected override void OnModelCreating(ModelBuilder constructor)
        {
            constructor.Entity<Tipo>(entidadTipo =>
            {
                entidadTipo.HasKey(e => e.Id);
                entidadTipo.HasIndex(e => e.Tiposnombre).IsUnique();

            });
            constructor.Entity<Pais>(entidadPais =>
            {

                entidadPais.HasKey(e => e.Id);
                entidadPais.HasIndex(e => e.Nombre).IsUnique();

            });
            constructor.Entity<Festivo>(entidadFestivos =>
            {
                entidadFestivos.HasKey(e => e.Id);

            });
            constructor.Entity<Festivo>()
                .HasOne(e => e.tipo)
                .WithMany()
                .HasForeignKey(e => e.IdTipo);
            constructor.Entity<Festivo>()
                .HasOne(e => e.pais)
                .WithMany()
                .HasForeignKey(e => e.IdPais);

        }

    }
}
