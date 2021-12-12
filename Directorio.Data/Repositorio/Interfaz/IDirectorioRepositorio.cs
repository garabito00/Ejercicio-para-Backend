using Directorio.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Directorio.Data.Repositorio.Interfaz
{
    public interface IDirectorioRepositorio
    {
        Task<IEnumerable<Persona>> GetDirectorio();
        Task<Persona> GetUnRegistro(int id);
        int AgregarPersonaAlDirectorio(Persona persona);
        void BorrarPersonaDelDirectorio(Persona persona);
        void AgregarContactoAlDirectorio(Contactos contacto);
        Task GuardarCambios();
    }
}
