using Directorio.Domain;
using Microsoft.EntityFrameworkCore;

namespace Directorio.Data.FluentAPI
{
    public static class ContactosFluent
    {
        public static void ContactosFluentAPI(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contactos>().ToTable("Contacto");
            modelBuilder.Entity<Contactos>().HasKey(c => c.ID);
            modelBuilder.Entity<Contactos>().Property(c => c.NumeroTelefonico).HasColumnName("NumeroTelefonico").HasColumnType("varchar").HasMaxLength(15);
        }
    }
}
