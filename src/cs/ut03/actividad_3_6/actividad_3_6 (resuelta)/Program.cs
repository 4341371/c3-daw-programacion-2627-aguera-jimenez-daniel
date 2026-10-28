namespace actividad_3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Vamos a calcular! Escribe un número entero positivo entre 10 y 20:");
        int limite_maximo = Convert.ToInt32(Console.ReadLine());
        // duplico las líneas anteriores y adapto para pedir también el número mínimo
        Console.WriteLine($"Escribe el número base, entre 1 y {limite_maximo}");
        int limite_minimo = Convert.ToInt32(Console.ReadLine());
        long sumatorio=0;
        long factorial=1;
        //PROFESOR::usando un bucle for, completa el programa para que calcule el sumatorio y el factorial del número introducido y los muestre por pantalla
        for (int n=limite_minimo;n<=limite_maximo;n++)
        {
            sumatorio = sumatorio + n; // forma abreviada equivalente: sumatorio += n;
            factorial = factorial * n; // forma abreviada equivalente: factorial *= n;
        }
        Console.WriteLine($"El sumatorio es {sumatorio}");
        Console.WriteLine($"El factorial es {factorial}");
    }
}
