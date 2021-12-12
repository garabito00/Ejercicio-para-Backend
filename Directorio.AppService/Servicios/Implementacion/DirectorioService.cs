using Directorio.AppService.Servicios.Interfaz;
using Directorio.Data.Repositorio.Interfaz;
using Directorio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directorio.AppService.Servicios.Implementacion
{
    public class DirectorioService : IDirectorioServicio
    {
        private readonly IDirectorioRepositorio repositorio;

        public DirectorioService(IDirectorioRepositorio _repositorio)
        {
            repositorio = _repositorio;
        }

        public async Task AgregarUnRegistroAlDirectorio(Persona persona)
        {
            var id = repositorio.AgregarPersonaAlDirectorio(persona);
            
            foreach (var contacto in persona.Contactos)
            {
                repositorio.AgregarContactoAlDirectorio(contacto);
            }

            await repositorio.GuardarCambios();
        }

        public async Task<IEnumerable<Persona>> GetDirectorio()
        {
            var directorio = await repositorio.GetDirectorio();
            if (directorio.Count() != 0)
            {
                return directorio;
            }
            else
            {
                throw new Exception("La base de datos no tiene registros");
            }
        }

        public async Task<Persona> GetUnRegistro(int id)
        {
            var registro = await repositorio.GetUnRegistro(id);
            if (registro != null)
            {
                return registro;
            }
            else
            {
                throw new Exception("Registro no existe en la base de datos");
            }
        }

        public async Task BorrarUnRegistro(int id)
        {
            var registro = await GetUnRegistro(id);
            repositorio.BorrarPersonaDelDirectorio(registro);
            await repositorio.GuardarCambios();
        }
        
    }
}
