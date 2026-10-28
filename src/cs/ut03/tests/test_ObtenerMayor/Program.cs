namespace test_ObtenerMayor;

class Program
{
    static void Main(string[] args)
    {
        int max = UtilidadesEnteros.ObtenerMayor(3,5);
        Console.WriteLine(max);    
        max = UtilidadesEnteros.ObtenerMayor(2,1);
        Console.WriteLine(max);
        max = UtilidadesEnteros.ObtenerMayor(4,8);
        Console.WriteLine(max);
        max = UtilidadesEnteros.ObtenerMayor(-1,-4);
        Console.WriteLine(max);       
    }

}

class UtilidadesEnteros
{
    public static int ObtenerMayor(int a, int b)
    {
        int mayor;
        if (a >= b)
        {
            mayor = a;
        }
        else
        {
            mayor = b;
        }
        return mayor;
    }
    
}
