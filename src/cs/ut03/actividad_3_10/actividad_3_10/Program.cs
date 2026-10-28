namespace actividad_3_10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe una palabra y yo me encargaré de acortarla hasta que quede en nada:");
        string palabra = Console.ReadLine() ?? string.Empty;

        do
        {
            if (palabra.Length >= 2)
            {
                palabra = palabra.Substring(1, palabra.Length - 2);
            }
            else
            {
                palabra = string.Empty;
            }

            Console.WriteLine(palabra);
        }
        while (palabra.Length > 0);
    }
}
