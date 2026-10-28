namespace actividad_3_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indica un número entero y yo intentaré decirte algo sobre él:");        
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 > 0)
        {
            Console.WriteLine("Positivo");
        }
        else if (num1 == 0)
        {
            Console.WriteLine("Es cero");
        }
        else
        {
            Console.WriteLine($"Negativo, su valor en positivo es {-(long)num1}");
        }

        if (num1 % 2 != 0)
        {
            Console.WriteLine("Es impar");
        }
        else if (num1 % 10 == 0)
        {
            Console.WriteLine("Es múltiplo de 10");
        }
        else
        {
            Console.WriteLine("Es par");
        }
    }
}
