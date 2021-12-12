using Directorio.Domain;
using Microsoft.EntityFrameworkCore;

namespace Directorio.Data.FluentAPI
{
    public static class PersonaFluent
    {
        public static void PersonaFluentApi(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().ToTable("personas");
            modelBuilder.Entity<Persona>().HasKey(p => p.ID);
            modelBuilder.Entity<Persona>().Property(p => p.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.Apellido).HasColumnName("Apellido").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.Correo).HasColumnName("Correo").HasColumnType("varchar").HasMaxLength(30).IsRequired();
        }
    }
}
