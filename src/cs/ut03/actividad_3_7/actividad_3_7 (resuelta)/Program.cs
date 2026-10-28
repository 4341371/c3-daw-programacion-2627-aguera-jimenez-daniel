namespace actividad_3_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce números positivos. Para terminar, introduce el cero o un número negativo:");
        int numero = Convert.ToInt32(Console.ReadLine());
        int sumatorio = 0;
        int contador = 0;
        //PROFESOR::usando un bucle while, completa el programa para que calcule el sumatorio de los números introducidos y lo muestre por pantalla
        while (numero>0)
        {
            sumatorio = sumatorio + numero; // forma abreviada: sumatorio += numero;
            contador++; //recordemos que x++ es la forma abreviada de x = x+1;
            // la última instrucción es volver a pedir otro número
            numero = Convert.ToInt32(Console.ReadLine());            
        }
        Console.WriteLine($"El contador es {contador}");
        Console.WriteLine($"El sumatorio es {sumatorio}");
        // Paso ahora a calcular y mostrar la media
        double media = (double)sumatorio / (double)contador;
        //ahora aplico el redondeo, antes de mostrarlo
        media = Math.Round(media,4);
        //una vez redondeada, la muestro
        Console.WriteLine($"La media es {media}");
    }
}
