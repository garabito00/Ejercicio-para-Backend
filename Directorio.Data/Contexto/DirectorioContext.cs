using Directorio.Data.FluentAPI;
using Directorio.Domain;
using Microsoft.EntityFrameworkCore;

namespace Directorio.Data.Contexto
{
    public class DirectorioContext : DbContext
    {
        public DirectorioContext(DbContextOptions<DirectorioContext> opciones) : base(opciones)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Contactos> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.PersonaFluentApi();
            modelBuilder.ContactosFluentAPI();
            modelBuilder.RelacionesFluentAPI();
        }
    }
}
