namespace actividad_3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca su nueva contraseña (mínimo 8 caracteres, conteniendo letras mayúsculas y minúsculas):"); 
        string password = Console.ReadLine() ?? string.Empty;

        if (password.Length < 8)
        {
            Console.WriteLine("Demasiado corta, debe contener al menos 8 caracteres");
        }
        else if (password == password.ToUpper())
        {
            Console.WriteLine("Debería contener alguna minúscula");
        }
        else if (password == password.ToLower())
        {
            Console.WriteLine("Debería contener alguna mayúscula");
        }
        else
        {
            Console.WriteLine("Repita la contraseña:");
            string confirmacion = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(password == confirmacion
                ? "Contraseña cambiada correctamente"
                : "Las contraseñas no coinciden");
        }
    }
}
