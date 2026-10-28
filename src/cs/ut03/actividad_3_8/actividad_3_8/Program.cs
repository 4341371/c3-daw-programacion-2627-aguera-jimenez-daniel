namespace actividad_3_8;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_MIN = 2;
        const int NUMERO_MAX = 10000;

        Console.WriteLine("Selecciona un número positivo (no mayor de 10000) y yo te diré sus divisores:");
        if (!int.TryParse(Console.ReadLine(), out int numero)
            || numero < NUMERO_MIN
            || numero > NUMERO_MAX)
        {
            Console.WriteLine($"El número debe estar entre {NUMERO_MIN} y {NUMERO_MAX} (incluidos).");
            return;
        }

        Console.WriteLine($"Los divisores de {numero} son:");
        int test_divisor = numero;
        int cantidad_divisores = 0;

        while (test_divisor >= NUMERO_MIN)
        {
            if (numero % test_divisor == 0)
            {
                Console.WriteLine($"El número {test_divisor} es divisor de {numero}");
                cantidad_divisores++;
            }

            test_divisor--;
        }

        Console.WriteLine($"Se han encontrado {cantidad_divisores} divisores");
    }
}
