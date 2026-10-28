namespace actividad_3_11;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        bool entradaValida = false;

        do
        {
            Console.WriteLine("Voy a mostrarte la tabla de multiplicar del número que me digas!");
            Console.Write("Introduce un número entre 1 y 10: ");
            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Debes introducir un número válido");
            }
            else if (numero < 1 || numero > 10)
            {
                Console.WriteLine("El número indicado debe estar entre 1 y 10");
            }
            else
            {
                entradaValida = true;
            }
        }
        while (!entradaValida);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
