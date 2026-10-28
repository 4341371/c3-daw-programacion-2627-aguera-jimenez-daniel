namespace actividad_2_1;
/* using permite referenciar tipos del espacio de nombres System.Diagnostics
  sin escribir su nombre completo. En este programa se necesita para usar Stopwatch. */
using System.Diagnostics;

class Program
{
  static void Main(string[] args)
  {
    Stopwatch cronometro = new Stopwatch();

    cronometro.Start(); // método Start de Stopwatch

    Console.WriteLine("Pulsa INTRO lo más rápido posible...");
    Console.ReadLine();

    cronometro.Stop(); // método Stop de Stopwatch

    // Elapsed es una propiedad (no un método): se consulta sin paréntesis.
    TimeSpan ts = cronometro.Elapsed;
    Console.WriteLine($"Has tardado {ts.Seconds} s. y {ts.Milliseconds} ms.");
  }
}
