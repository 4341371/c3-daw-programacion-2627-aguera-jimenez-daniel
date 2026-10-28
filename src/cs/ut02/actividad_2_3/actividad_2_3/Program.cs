namespace actividad_2_3;

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona
        {
            tratamiento = "D.",
            nombre = "Daniel",
            primerApellido = "Aguera",
            segundoApellido = "Jiménez"
        };

        Persona persona2 = new Persona
        {
            tratamiento = "Dña.",
            nombre = "Lucía",
            primerApellido = "García",
            segundoApellido = "López"
        };

        Console.WriteLine(persona1.ObtenerNombreYApellidos());
        Console.WriteLine(persona1.ObtenerApellidosYNombre());
        Console.WriteLine(persona1.ObtenerTratamientoNombreYPrimerApellido());

        Console.WriteLine(persona2.ObtenerNombreYApellidos());
        Console.WriteLine(persona2.ObtenerApellidosYNombre());
        Console.WriteLine(persona2.ObtenerTratamientoNombreYPrimerApellido());
    }
}

class Persona
{
    public string tratamiento = string.Empty;
    public string nombre = string.Empty;
    public string primerApellido = string.Empty;
    public string segundoApellido = string.Empty;

    // Devuelve nombre y apellidos en ese orden, separados por espacios.
    public string ObtenerNombreYApellidos()
    {
        return $"{nombre} {primerApellido} {segundoApellido}";
    }

    // Devuelve los apellidos seguidos de una coma y el nombre.
    public string ObtenerApellidosYNombre()
    {
        return $"{primerApellido} {segundoApellido}, {nombre}";
    }

    // Devuelve el tratamiento, el nombre y el primer apellido.
    public string ObtenerTratamientoNombreYPrimerApellido()
    {
        return $"{tratamiento} {nombre} {primerApellido}";
    }
}