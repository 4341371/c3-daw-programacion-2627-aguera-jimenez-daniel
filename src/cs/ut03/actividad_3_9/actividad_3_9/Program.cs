namespace actividad_3_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce una palabra");
        string palabra = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Introduce un número de repeticiones:");
        int repeticiones = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < repeticiones; i++)
        {
            Console.Write(palabra);
            if (i < repeticiones - 1)
            {
                Console.Write(",");
            }
        }

        Console.WriteLine();
    }
}
