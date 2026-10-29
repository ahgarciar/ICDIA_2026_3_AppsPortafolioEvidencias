using System.Collections;
using ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes.DefComputadora;

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

public static void Ejecuta_TryCatch3(){
        
        try {   
            Console.WriteLine("Número: ");
            int numero = int.Parse(Console.ReadLine()!);
        }
        catch (FormatException){ 
            Console.WriteLine("Formato incorrecto.");
        }
        catch (OverflowException){
            Console.WriteLine("Número demasiado grande.");
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    
}

public static void Ejecuta_TryCatchFinally(){
        
        try {   
            Console.WriteLine("Número: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.WriteLine("El número ingresado es: " + numero);
        }
        catch (FormatException){ 
            Console.WriteLine("Formato incorrecto.");
        }
        catch (OverflowException){
            Console.WriteLine("Número demasiado grande.");
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Ejecución del apunte terminado!!");
        }
    
}

public static void Ejecuta_EjemploTryParse()
    {
        try{
            Console.WriteLine("Edad: ");
            string entrada = Console.ReadLine();
            int edad;
            
            if (int.TryParse(entrada,out edad)){
                Console.WriteLine($"Edad válida: {edad}");
            }
            else{ 
                Console.WriteLine("Debe escribir un número entero.");
                }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Ejecución del apunte terminado");
        }

}

public static void Ejecutar_ConstruyeComputadora()
    {
        
        Computadora pc1 = new Computadora("Mi computadora");
        Console.WriteLine("Computadora creada!");

        DefComputadora.Monitor monitor1 = new DefComputadora.Monitor("LG", 34);
        DefComputadora.Monitor monitor2 = new DefComputadora.Monitor("Samsung", 27);

        //Computadora usa el monitor 1
        pc1.MonitorC = monitor1;
        Console.WriteLine("Computadora conectada al monitor 1");

        //Computadora usa el monitor 2
        pc1.MonitorC = monitor2;
        Console.WriteLine("Computadora conectada al monitor 2");

    }


public static void EscribirArchivo1()
    {
        using StreamWriter streamWriter = new StreamWriter("datos.txt");
        streamWriter.WriteLine("Felipe");
        streamWriter.WriteLine("Javier");
        streamWriter.WriteLine("Diego");

    }



public static void EscribirArchivo2(bool append)
    {
        //                                                 Ruta relativa
        using StreamWriter streamWriter = new StreamWriter("datos.txt",  append);
        streamWriter.WriteLine("Felipe");
        streamWriter.WriteLine("Javier");
        streamWriter.WriteLine("Diego");

    }


public static List<string> LeerArchivoV1(string nombreArchivo)
    {
        List<string> archivo = new List<string>();

        using StreamReader lector = new StreamReader(nombreArchivo);
        
        //permite que la variable almacene valores null
        string? linea;
        
        while ((linea = lector.ReadLine()) != null) { //EOF
             Console.WriteLine(linea);
             archivo.Add(linea);
        }        

        return archivo;
    }

public static void LeerArchivoV2(string nombreArchivo)
    {
        List<string> archivo = LeerArchivoV1(nombreArchivo);
        List<AlumnoCalificacion> alumnos = new List<AlumnoCalificacion>();

        Console.WriteLine("\nArchivo Procesado: ");
        foreach(string linea in archivo){
            string[] temp = linea.Split("@");

            string nombre = temp[0].Trim();
            int calificacion = Convert.ToInt32(temp[1]);
            
            AlumnoCalificacion auxiliar = new AlumnoCalificacion(nombre, calificacion);
            alumnos.Add(auxiliar);

            Console.WriteLine(auxiliar);
        }
        Console.WriteLine();

    }




}