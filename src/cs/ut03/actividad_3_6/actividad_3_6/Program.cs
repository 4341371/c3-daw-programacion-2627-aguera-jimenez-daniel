namespace actividad_3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Vamos a calcular! Escribe un número entero positivo entre 10 y 20:");
        int limite_maximo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Introduce el entero base para el cálculo, entre 1 y {limite_maximo}");
        int limite_minimo = Convert.ToInt32(Console.ReadLine());
        long sumatorio=0;
        long factorial=1;
        for (int n = limite_minimo; n <= limite_maximo; n++)
        {
            sumatorio += n;
            factorial *= n;
        }

        Console.WriteLine($"El sumatorio es {sumatorio}");
        Console.WriteLine($"El factorial es {factorial}");
    }
}
