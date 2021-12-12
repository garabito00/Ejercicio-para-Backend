using Directorio.Data.Contexto;
using Directorio.Data.Repositorio.Interfaz;
using Directorio.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Directorio.Data.Repositorio.Implementacion
{
    public class DirectorioRepositorio : IDirectorioRepositorio
    {
        private readonly DirectorioContext dbContext;

        public DirectorioRepositorio(DirectorioContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AgregarContactoAlDirectorio(Contactos contacto)
        {
            dbContext.Contactos.Add(contacto);
        }

        public int AgregarPersonaAlDirectorio(Persona persona)
        {
            dbContext.Personas.Add(persona);
            return persona.ID;
        }

        public async Task GuardarCambios()
        {
            await dbContext.SaveChangesAsync();
        }

        public void BorrarPersonaDelDirectorio(Persona persona)
        {
            dbContext.Personas.Remove(persona);
        }

        public async Task<IEnumerable<Persona>> GetDirectorio()
        {
            var directorio = await dbContext.Personas.Include(p => p.Contactos).ToListAsync();
            return directorio;
        }

        public async Task<Persona> GetUnRegistro(int id)
        {
            return await dbContext.Personas.Include(p => p.Contactos).FirstOrDefaultAsync(p => p.ID == id);
        }
    }
}
