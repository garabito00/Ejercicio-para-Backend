using System.Collections.Generic;

namespace Directorio.Domain
{
    public class Persona
    {
        //Propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }

        //Relacion
        public IEnumerable<Contactos> Contactos { get; set; }
    }
}
