namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes;

public static class P00_Ejectures
{
    
    public static Alumno Ejecuta_P02_Alumo()
    {
        Alumno alumno1; //declaracion
        alumno1 = new Alumno(); //instanciacion
                                //alumno1.Nombre = ""; //Error porque esta vacio
                                //alumno1.Nombre = "   "; //Error porque esta vacio

        Console.WriteLine("ingresa el nombre del alumno: ");
        do{
            try
            {
                alumno1.Nombre = Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("El nombre no tiene el formato correcto, intenta nuevamente");
            }
        }while(alumno1.Nombre == null);

        Console.WriteLine("Alumno creado!");

        return alumno1;

    }

    public static void Ejecutar_P02_Alumo_CalcularPromedio()
    {
       Alumno alumn = Ejecuta_P02_Alumo(); //creando y recuperand un alumno

       List<double> lista_calificaciones; //declaracion
       lista_calificaciones = new List<double>(); //instanciacion
       lista_calificaciones.Add(8); //asignacion de valores
       lista_calificaciones.Add(7);
       lista_calificaciones.Add(9);

       double promedio = alumn.CalcularPromedio(lista_calificaciones); //calcular el promedio 

       Console.WriteLine(" El promedio del alumno es: " + promedio);

    }

    public static void Ejecuta_P03_Dataset()
    {
        
    }

    //....

    public static void Ejecuta_TryCatch1()
    {
        try {
                //int numero = int.Parse("ABC");
                Console.WriteLine("Ingresa un número: ");
                int numero = int.Parse(Console.ReadLine());
        }
        catch (FormatException) {
            Console.WriteLine("El texto no es un número entero.");
        }
    }


public static void Ejecuta_TryCatch2()
    {
        try {
                //int numero = int.Parse("ABC");
                Console.WriteLine("Ingresa un número: ");
                int numero = int.Parse(Console.ReadLine());
        }
        catch (FormatException exception) {
            Console.WriteLine(exception.Message);
        }
    }

}