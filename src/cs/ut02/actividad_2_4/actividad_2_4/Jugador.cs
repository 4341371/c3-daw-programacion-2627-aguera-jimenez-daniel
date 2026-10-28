namespace actividad_2_4;

class Jugador
{
    public string nombre = string.Empty;
    public string apodo = string.Empty;
    public Equipo? equipo; // referencia al objeto "Equipo" en el que juega
    public int dorsal; //número de dorsal en el equipo

    public string GetNombreCorto()
    {
        return string.IsNullOrEmpty(apodo) ? nombre : apodo;
    }

    public string GetNombreEquipo()
    {
        return equipo == null ? "<<sin equipo>>" : equipo.nombre;
    }
}