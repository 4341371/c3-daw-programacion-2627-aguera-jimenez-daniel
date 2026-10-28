namespace test_while1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce números enteros. El cero (0) termina.");
        int numero = int.Parse(Console.ReadLine());
        while (numero != 0)
        {
            Console.WriteLine($"Has escrito el {numero}. Introduce otro. Recuerda indicar cero (0) para salir.");
            numero = int.Parse(Console.ReadLine());
        }
    }
}
