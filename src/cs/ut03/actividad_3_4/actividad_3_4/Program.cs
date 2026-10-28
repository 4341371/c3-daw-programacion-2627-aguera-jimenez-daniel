namespace actividad_3_4;

class Program
{
    static void Main(string[] args)
    {
        const string RATING_1 = "horroroso";
        const string RATING_2 = "malo";
        const string RATING_3 = "regulero";
        const string RATING_4 = "interesante";
        const string RATING_5 = "maravilloso";
        const string RATING_TEXT = "El curso te parece ";
        const string RATING_ERROR = "Debes indicar un valor entre 1 y 5 (incluidos)";

        Console.WriteLine("Califica tu experiencia con el curso (1-5):");
        int calificacion = Convert.ToInt32(Console.ReadLine());
        string mensaje;

        switch (calificacion)
        {
            case 1:
                mensaje = RATING_TEXT + RATING_1;
                break;
            case 2:
                mensaje = RATING_TEXT + RATING_2;
                break;
            case 3:
                mensaje = RATING_TEXT + RATING_3;
                break;
            case 4:
                mensaje = RATING_TEXT + RATING_4;
                break;
            case 5:
                mensaje = RATING_TEXT + RATING_5;
                break;
            default:
                mensaje = RATING_ERROR;
                break;
        }

        Console.WriteLine(mensaje);
    }
}
