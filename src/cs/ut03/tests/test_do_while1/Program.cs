namespace test_do_while1;

class Program
{
    static void Main(string[] args)
    {
        int eleccion=0;
        do
        {
            Console.WriteLine("Indique una opción, del 1 al 5 (0 para salir)");
            eleccion = int.Parse(Console.ReadLine());
            if (eleccion>=1 && eleccion<=5)
            {
                Console.WriteLine($"Ha elegido {eleccion}");    
            }
            else
            {
                Console.WriteLine($"La opción {eleccion} no es válida");
            }
            
        } while (eleccion!=0);
    }
}
