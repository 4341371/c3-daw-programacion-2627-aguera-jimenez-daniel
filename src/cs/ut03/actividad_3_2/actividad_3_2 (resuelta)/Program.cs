namespace actividad_3_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indica un número entero y yo intentaré decirte algo sobre él:");        
        int num1 = Convert.ToInt32(Console.ReadLine());
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
        if (num1>0) // detecto que el número es positivo
        {
            Console.WriteLine("Positivo");
        }
        else if (num1==0)
        {
            Console.WriteLine("Es cero");            
        }
        else // si no es cero ni positivo, será negativo
        {
            int num1_en_positivo = -num1; // tb podría ser = num1 * -1;
            Console.WriteLine($"Negativo, su valor en positivo es {num1_en_positivo}");
        }
        // Voy a comprobar si es par o impar
        // para ello, veré si es múltiplo de 2
        if (num1 % 2 ==0)
        {
            if (num1 % 10 ==0)
            {
                Console.WriteLine("Es múltiplo de 10");
            }
            else
            {
                Console.WriteLine("Es par");    
            }            
        }
        else
        {
            Console.WriteLine("Es impar");
        }
    }
}
