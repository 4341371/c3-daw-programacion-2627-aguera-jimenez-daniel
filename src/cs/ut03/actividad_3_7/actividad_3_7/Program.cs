namespace actividad_3_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce números positivos. Para terminar, introduce el cero o un número negativo:");
        int numero = Convert.ToInt32(Console.ReadLine());
        long sumatorio = 0;
        int contador = 0;
        while (numero > 0)
        {
            sumatorio += numero;
            contador++;
            numero = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"El contador es {contador}");
        Console.WriteLine($"El sumatorio es {sumatorio}");
        if (contador == 0)
        {
            Console.WriteLine("No se introdujeron números positivos; no se puede calcular la media.");
        }
        else
        {
            double media = (double)sumatorio / contador;
            Console.WriteLine($"La media es {Math.Round(media, 4)}");
        }
    }
}
