namespace actividad_2_4;

class Program
{
    static void Main(string[] args)
    {
        Equipo equipo = new Equipo { nombre = "Los Leones" };
        Jugador jugadorConApodo = new Jugador
        {
            nombre = "Carlos",
            apodo = "El Rayo",
            dorsal = 10
        };
        Jugador jugadorSinApodo = new Jugador
        {
            nombre = "María",
            dorsal = 7
        };

        Console.WriteLine(jugadorConApodo.GetNombreCorto());
        Console.WriteLine(jugadorSinApodo.GetNombreCorto());
        Console.WriteLine(jugadorConApodo.GetNombreEquipo());

        equipo.Fichar(jugadorConApodo);
        equipo.Fichar(jugadorSinApodo);

        Console.WriteLine(jugadorConApodo.GetNombreEquipo());
        Console.WriteLine(jugadorSinApodo.GetNombreEquipo());
        Console.WriteLine($"Jugadores fichados: {equipo.jugadores}");
    }
}
