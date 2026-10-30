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
             Console.WriteLine("--- APARTADO C ---");
            // c.2: Solicita el número desde el que comienza la cuenta atrás
            Console.Write("Introduce el número de inicio para la cuenta atrás: ");
            int inicioCuenta = int.Parse(Console.ReadLine() ?? "10");

            // c.1 y c.2: Cuenta atrás desde el número introducido hasta 0
            for (int i = inicioCuenta; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


             //apartado d - usando bucles while, desarrolla aquí el código que pide el enunciado:
            Console.WriteLine("--- APARTADO D ---");
            // d.1: Solicita un número y multiplica por 10 mientras sea menor que 10000
            Console.Write("Introduce un número entero: ");
            int numeroD = int.Parse(Console.ReadLine() ?? "0");

            while (numeroD < 10000)
            {
                Console.WriteLine(numeroD);
                numeroD *= 10;
            }

            // d.2: Muestra el mensaje al finalizar
            Console.WriteLine($"Bucle finalizado con el valor {numeroD}");
            Console.WriteLine();


             //apartado e - usando un bucle do-while, desarrolla aquí el código que pide el enunciado:
           
            Console.WriteLine("--- APARTADO E ---");
            string? palabra;
            string palabrasAcumuladas = "";

            // e.1: Bucle do-while mientras la palabra no sea la cadena vacía ("")
            do
            {
                Console.Write("Introduce una palabra (o presiona Enter para terminar): ");
                palabra = Console.ReadLine();

                if (!string.IsNullOrEmpty(palabra))
                {
                    // e.2: Acumula las palabras separadas por espacio
                    palabrasAcumuladas += palabra + " ";
                }
            } while (!string.IsNullOrEmpty(palabra));

            // e.2: Muestra todas las palabras introducidas al finalizar
            Console.WriteLine($"Palabras introducidas: {palabrasAcumuladas.Trim()}");
            Console.WriteLine();


             //apartado f - usando diferentes condicionales y bucles, con posible anidación, desarrolla aquí el código que pide el enunciado:

            Console.WriteLine("--- APARTADO F ---");
            // f.1, f.2 y f.3: Recorrer del 1 al 20, aplicar formato de dos dígitos y switch-case
            for (int i = 1; i <= 20; i++)
            {
                // f.2: Formato de dos dígitos ('01', '02', ..., '10', '11')
                string numeroFormateado = i.ToString("00");

                // f.3: Estructura switch-case para '01', '10' y '20'
                switch (numeroFormateado)
                {
                    case "01":
                        Console.WriteLine($"{numeroFormateado} primero");
                        break;
                    case "10":
                        Console.WriteLine($"{numeroFormateado} mitad");
                        break;
                    case "20":
                        Console.WriteLine($"{numeroFormateado} último");
                        break;
                    default:
                        Console.WriteLine(numeroFormateado);
                        break;
                }
            }
            Console.WriteLine();


             //apartado g  - usando condicionales, desarrolla aquí el código que pide el enunciado:
            Console.WriteLine("--- APARTADO G ---");
            int repeticiones = 0;

            // g.1, g.2 y g.3: Capturar excepciones y usar el bloque 'finally'
            try
            {
                Console.Write("Indique el número de repeticiones: ");
                repeticiones = int.Parse(Console.ReadLine() ?? "");
            }
            catch (Exception)
            {
                // g.1 y g.2: Mensaje de error y asignación de 0
                Console.WriteLine("El número introducido no es válido");
                repeticiones = 0;
            }
            finally
            {
                // g.3: Instrucción garantizada
                Console.WriteLine($"El número de repeticiones ha sido: {repeticiones}");
            }
        }
    }
}
