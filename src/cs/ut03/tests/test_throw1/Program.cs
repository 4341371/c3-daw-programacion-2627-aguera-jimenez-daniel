namespace test_throw1;

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Hola!, introduce tu DNI y tu edad:");
            
            string dni = Console.ReadLine();
            Validaciones.CheckDNI(dni);

            int edad = int.Parse(Console.ReadLine());
            Validaciones.CheckEdad(edad);

            Console.WriteLine($"Pues, te veo muy bien para tener {edad} años!");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se ha producido un error: {ex.Message}");
        }
        
    }
}

class Validaciones
{
    public static void CheckEdad(int edad)
    {
        if (edad<0 || edad>150)
        {
            throw new ArgumentOutOfRangeException("edad","La edad tiene que estar entre 0 y 150 (ambos inclusive)");
        }
    }
    public static void CheckDNI(string dni)
    {
        // 1. Validar que el argumento no sea nulo
        if (dni == null)
        {
            throw new ArgumentNullException(nameof(dni), "El DNI no puede ser nulo.");
        }

        // 2. Limpiar espacios y convertir a mayúsculas
        string dniLimpio = dni.Trim().ToUpper();

        // 3. Validar el formato básico mediante Expresión Regular (8 números y 1 letra)
        if (!Regex.IsMatch(dniLimpio, @"^[0-9]{8}[A-Z]$"))
        {
            throw new FormatException("El formato del DNI es incorrecto. Debe contener 8 números seguidos de una letra (ej. 12345678Z).");
        }

        // 4. Extraer los números y la letra provista
        string numeroTexto = dniLimpio.Substring(0, 8);
        char letraProvista = dniLimpio[8];

        // 5. Calcular la letra matemática correcta (Algoritmo oficial del Ministerio)
        // El orden de las letras en este string es estricto y responde al resto de la división por 23
        const string LetrasValidas = "TRWAGMYFPDXBNJZSQVHLCKE";
        
        int numero = int.Parse(numeroTexto); // Seguro de parsear gracias al Regex anterior
        int resto = numero % 23;
        char letraCorrecta = LetrasValidas[resto];

        // 6. Comprobar si la letra coincide
        if (letraProvista != letraCorrecta)
        {
            throw new ArgumentException($"La letra '{letraProvista}' no es correcta para el número de DNI introducido. La letra calculada debería ser '{letraCorrecta}'.");
        }       
        // Si llega aquí, el DNI es 100% válido y correcto.


    }
}
