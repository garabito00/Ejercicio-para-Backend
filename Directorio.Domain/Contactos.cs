namespace Directorio.Domain
{
    public class Contactos
    {
        //Propiedades
        public int ID { get; set; }
        public int PersonaID { get; set; }
        public string NumeroTelefonico { get; set; }

        //Relaciones
        public Persona Persona { get; set; }
    }
}
