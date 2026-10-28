namespace actividad_3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca su nueva contraseña (mínimo 8 caracteres, conteniendo letras mayúsculas y minúsculas):"); 
        string password = Console.ReadLine();
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
        // declaro una variable entera para quedarme con la longitud de la cadena introducida por el usuario
        int longitud_password = password.Length;
        // comparlo para averiguar si cumple con la longitud mínima
        if (longitud_password<8)
        {
            Console.WriteLine("Demasiado corta, debe contener al menos 8 caracteres");
        }
        else
        {
            // voy a declarar y asignar dos variables con las versiones
            // en mayúsculas y minúsculas del password introducido
            string pass_en_mayusculas = password.ToUpper();
            string pass_en_minusculas = password.ToLower();
            if (password==pass_en_mayusculas)
            {
                Console.WriteLine("Debería contener alguna minúscula");
            }
            // pongo else para poder aislar (en el último else)...
            // ,,,el caso de que todas las comprobaciones han ido bien
            else if (password==pass_en_minusculas)
            {
                Console.WriteLine("Debería contener alguna mayúscula");
            }
            else // pasamos a repetir la contraseña
            {
                // pido otra vez la contraseña
                Console.WriteLine("Repita la contraseña:"); 
                string password2 = Console.ReadLine();
                //compruebo que coincida con la anterior
                if (password==password2)
                {
                    Console.WriteLine("Contraseña cambiada correctamente");
                }
                else
                {
                    Console.WriteLine("Las contraseñas no coinciden");
                }
            }
        }
        
    }
}
