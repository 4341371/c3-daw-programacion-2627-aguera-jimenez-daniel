namespace test_excepciones2;

class Program
{
    static void Main(string[] args)
    {
        bool reintentar; // variable para determinar si hay que volver a introducir los datos
        do
        {   
            reintentar=false; // al principio de cada intento, asumimos que no habrá que reintentar
            try
            {
                //Tomamos los datos del usuario:
                Console.WriteLine("Introduzca dividendo:");
                int dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca divisor:");
                int divisor = int.Parse(Console.ReadLine());
                //Calculamos las operaciones       
                int cociente = dividendo / divisor;
                int resto = dividendo % divisor;
                //Mostramos los cálculos al usuario
                Console.WriteLine($"El cociente de la división es {cociente}");
                Console.WriteLine($"El resto de la división es {resto}");            
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Alguno de los números no tiene un formato correcto");
                reintentar=true; // como se ha producido una excepción, decimos que sí hay que reintentar
            }
            //Aquí el tratamiento por si alguien pone cero de divisor
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Se ha intentado dividir por cero: {ex:Message}");            
                reintentar=true; // como se ha producido una excepción, decimos que sí hay que reintentar
            }
            //Esto se ejecuta siempre
            finally
            {
                Console.WriteLine("Felizmente, pase lo que pase, esto se va a ejecutar");
            }
            //Pongo esta línea para ver si el programa se ha interrumpido o no
            Console.WriteLine("El programa termina aquí");
        } while (reintentar); // esto es lo que realmente provocará que se comience de nuevo otra toma de datos, cálculos y muestra de resultados
    }
}
