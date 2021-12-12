using Directorio.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Directorio.AppService.Servicios.Interfaz
{
    public interface IDirectorioServicio
    {
        Task<IEnumerable<Persona>> GetDirectorio();
        Task<Persona> GetUnRegistro(int id);
        Task AgregarUnRegistroAlDirectorio(Persona persona);
        Task BorrarUnRegistro(int id);
    }
}
