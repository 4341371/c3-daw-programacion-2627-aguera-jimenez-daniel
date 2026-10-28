namespace actividad_3_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vas a indicar dos números en orden creciente:");
        Console.WriteLine("Indica el primer número:");        
        int num1 = Convert.ToInt32(Console.ReadLine());
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
        Console.WriteLine("Indica el segundo número:");   
        int num2 = Convert.ToInt32(Console.ReadLine());  
        if (num1<num2)
        {
            Console.WriteLine("OK!");
        }
        else if (num1==num2)
        {
            Console.WriteLine("IGUALES!");
        }
        else
        {
            Console.WriteLine($"INCORRECTO: deberías haber indicado {num2} y {num1}");
        }
    }
}
