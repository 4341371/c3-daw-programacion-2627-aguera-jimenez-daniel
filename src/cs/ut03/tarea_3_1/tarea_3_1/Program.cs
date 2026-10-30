namespace tarea_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //apartado b - usando condicionales, desarrolla aquí el código que pide el enunciado:
            Console.WriteLine("--- APARTADO B ---");
            Console.Write("Introduce la primera cadena de texto: ");
            string? cadena1 = Console.ReadLine();

            Console.Write("Introduce la segunda cadena de texto: ");
            string? cadena2 = Console.ReadLine();

            // b.1 y b.2: Comparación exacta y sin distinguir mayúsculas/minúsculas
            if (cadena1 == cadena2)
            {
                Console.WriteLine("Iguales");
            }
            else if (string.Equals(cadena1, cadena2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Semejantes");
            }
            else
            {
                Console.WriteLine("Diferentes");
            }
            Console.WriteLine();


              //apartado c - usando un bucle for, desarrolla aquí el código que pide el enunciado:
          


             //apartado d - usando bucles while, desarrolla aquí el código que pide el enunciado:
           


             //apartado e - usando un bucle do-while, desarrolla aquí el código que pide el enunciado:
           


             //apartado f - usando diferentes condicionales y bucles, con posible anidación, desarrolla aquí el código que pide el enunciado:

           


             //apartado g  - usando condicionales, desarrolla aquí el código que pide el enunciado:
         
    }
}
