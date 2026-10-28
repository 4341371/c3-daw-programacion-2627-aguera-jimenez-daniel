namespace test_excepciones1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número entero: ");
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Has introducido el número {numero}");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Debes introducir alto: {ex.Message}");
        }    
        catch (FormatException ex)
        {
            Console.WriteLine($"El texto introducido no tiene formato de número: {ex.Message}");
        }    
        catch (OverflowException ex)
        {
            Console.WriteLine($"El número indicado es demasiado grande: {ex.Message}");
        }    
        Console.WriteLine("El programa no se ha interrumpido, y por eso se imprime esta línea");
    }
}
