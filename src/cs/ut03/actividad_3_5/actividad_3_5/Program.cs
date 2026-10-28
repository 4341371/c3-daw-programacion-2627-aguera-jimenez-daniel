namespace actividad_3_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Vamos a contar! Escribe un número entero positivo entre 10 y 20:");
        int limite_maximo = Convert.ToInt32(Console.ReadLine());
        for (int numero = 1; numero <= limite_maximo; numero++)
        {
            Console.WriteLine(numero);
        }
    }
}
