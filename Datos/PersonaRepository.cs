system.data.sqlClient();


namespace Datos
{

    public class PersonaRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<Persona> _Personas;

    }
}