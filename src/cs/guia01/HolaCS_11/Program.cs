Console.Write("Introduce el primer sumando: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Introduce el segundo sumando: ");
int b = Convert.ToInt32(Console.ReadLine());

int suma = Sumar(a, b);

Console.WriteLine($"Resultado: {suma}");

static int Sumar(int x, int y)
{
    int resultado = x + y;
    return resultado;
}