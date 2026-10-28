namespace actividad_2_4;

class Equipo
{
    public string nombre = string.Empty;
    public int jugadores;

    public void Fichar(Jugador jugador)
    {
        jugador.equipo = this;
        jugadores++;
    }
}