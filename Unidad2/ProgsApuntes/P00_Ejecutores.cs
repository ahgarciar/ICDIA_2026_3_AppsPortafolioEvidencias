namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes;

public static class P00_Ejectures
{
    
    public static void Ejecuta_P02_Alumo()
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


    }

    public static void Ejecuta_P03_Dataset()
    {
        
    }

    //....


}