using Directorio.Domain;
using Microsoft.EntityFrameworkCore;

namespace Directorio.Data.FluentAPI
{
    public static class RelacionesFluent
    {
        public static void RelacionesFluentAPI(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contactos>().HasOne<Persona>(c => c.Persona).WithMany(p => p.Contactos).HasForeignKey(c => c.PersonaID);
        }
    }
}
