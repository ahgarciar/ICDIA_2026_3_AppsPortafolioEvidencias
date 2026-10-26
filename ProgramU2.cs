
using ICDIA_2026_3_AppsPortafolioEvidencias.Models;
using ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;
using ICDIA_2026_3_AppsPortafolioEvidencias.RunnersEjerciciosEquipo;
using ICDIA_2026_3_AppsPortafolioEvidencias.Unidad1.ProgsApuntes;

using ICDIA_2026_3_AppsPortafolioEvidencias.EjerciciosEquipo;

using ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes;

namespace ICDIA_2026_3_AppsPortafolioEvidencias;

public class ProgramU2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Unidad 2. Programas iniciado...\n");
    
        int tipoPrograma;
        do{
        Console.WriteLine("Quiere ejecutar un programa de Apuntes o de Ejercicios");
        Console.WriteLine("1: Apuntes");
        Console.WriteLine("2: Ejercicios");
        Console.WriteLine("3: Salir");
        bool esValida = int.TryParse(Console.ReadLine(), out tipoPrograma);
            if (!esValida)
            {
                tipoPrograma = -1;
            }

            switch (tipoPrograma)
            {
                case 1:
                    Console.WriteLine("Programas de Apuntes!!");
                    MenuProgramasApuntes();
                break;
                case 2:
                    Console.WriteLine("Programas de Ejercicios!!");
                    MenuProgramasEjercicios();
                break;
                case 3: //No se hace nada aqui, pero es necesario colocarlo, 
                //para que no se imprima algun texto no deseado cuando se desee salir 
                //del programa
                break;
                default:
                Console.WriteLine("Opción no valida!!");
                break;
            }

        }
        while(tipoPrograma != 3);

    Console.WriteLine("Gracias por usuar nuestro Programa :D! alt+3");

}

public static void MenuProgramasApuntes()
    {
        int apunte;
        do{
        Console.WriteLine("Que apunte desea ejecutar?");
        Console.WriteLine("1: Lista Genéricas");
        Console.WriteLine("2: Clase Alumno");
        Console.WriteLine("3: Clase Alumno - Calcular Promedio");
        Console.WriteLine("4: Clase Dataset");
        Console.WriteLine("5: Try-Catch 1");
        Console.WriteLine("6: Try-Catch 2 (con Message)");
        Console.WriteLine("7: Try-Catch 3 (con Message)");
        Console.WriteLine("8: Try-Catch-Finally");
        Console.WriteLine("9: Try-Parse");
        Console.WriteLine("10: Composición de clases: Computadora");
        Console.WriteLine("11: Escribir Archivo 1");
        Console.WriteLine("12: Escribir Archivo 2 - append");
        Console.WriteLine("100: Salir");
        bool esValida = int.TryParse(Console.ReadLine(), out apunte);
            if (!esValida)
            {
                apunte = -1;
            }

            switch (apunte)
            {
                //se genera un case por cada apunte que se pueda ejecutar
                case 1:
                    Console.WriteLine("Ejecución del apunte 1");
                    ///////////////////////////////////////////////////////
                    /// SECCION A MODIFICAR POR APUNTE!
                    P01_Dataset apunte1 = new P01_Dataset();
                    apunte1.Ejecutar();
                    ///////////////////////////////////////////////////////
                    Console.WriteLine("_Ejecución terminada!\n");
                break;
                case 2:
                    Console.WriteLine("Ejecución del apunte 2: Clase Alumno");
                    P00_Ejectures.Ejecuta_P02_Alumo();
                break;
                case 3:
                    Console.WriteLine("Ejecución del apunte 3: Clase Alumno - Calcular Promedio");
                    P00_Ejectures.Ejecutar_P02_Alumo_CalcularPromedio();
                break;
                case 4:
                    Console.WriteLine("Ejecución del apunte 4: Clase Dataset");
                    P00_Ejectures.Ejecuta_P03_Dataset();
                break;
                case 5:
                    Console.WriteLine("Ejecución del apunte 5: Try-Catch 1");
                    P00_Ejectures.Ejecuta_TryCatch1();
                break;
                case 6:
                    Console.WriteLine("Ejecución del apunte 6: Try-Catch 2 (con Message)");
                    P00_Ejectures.Ejecuta_TryCatch2();
                break;
                case 7:
                    Console.WriteLine("Ejecución del apunte 7: Try-Catch 3 (con Message)");
                    P00_Ejectures.Ejecuta_TryCatch3();
                break;
                case 8:
                    Console.WriteLine("Ejecución del apunte 8: Try-Catch-Finally");
                    P00_Ejectures.Ejecuta_TryCatchFinally();
                    break;
                case 9:
                    Console.WriteLine("Ejecución del apunte 9: Try-Parse");
                    P00_Ejectures.Ejecuta_EjemploTryParse();            
                break;
                case 10:
                    Console.WriteLine("Ejecución del apunte 10: Composición de clases: Computadora");
                    P00_Ejectures.Ejecutar_ConstruyeComputadora();            
                break;
                case 11:
                    Console.WriteLine("Ejecución del apunte 11: Escribir Archivo 1");
                    P00_Ejectures.EscribirArchivo1();            
                break;
                case 12:
                    Console.WriteLine("Ejecución del apunte 12: Escribir Archivo 2");
                    P00_Ejectures.EscribirArchivo2(true);            
                break;


                case 100: //No se hace nada aqui, pero es necesario colocarlo, 
                //para que no se imprima algun texto no deseado cuando se desee salir 
                //del programa
                break;
                default:
                Console.WriteLine("Opción no valida!!");
                break;
            }

        }
        while(apunte != 100);

        Console.WriteLine("Ejecución de apuntes terminada! \n");
    }

public static void MenuProgramasEjercicios()
    {
        int ejercicio;
        do{
        Console.WriteLine("Que ejercicio desea ejecutar?");
        Console.WriteLine("1: ");
        Console.WriteLine("2: ");
        Console.WriteLine("3: ");
        Console.WriteLine("4: ");
        Console.WriteLine("5: ");
        Console.WriteLine("100: Salir");
        bool esValida = int.TryParse(Console.ReadLine(), out ejercicio);
            if (!esValida)
            {
                ejercicio = -1;
            }

            switch (ejercicio)
            {
                //se genera un case por cada apunte que se pueda ejecutar
                case 1:
                    Console.WriteLine("Ejecución del ejercicio 1");
                break;
                case 2:
                    Console.WriteLine("Ejecución del ejercicio 2");
                break;
                case 3:
                    Console.WriteLine("Ejecución del ejercicio 3");
                break;


                case 100: //No se hace nada aqui, pero es necesario colocarlo, 
                //para que no se imprima algun texto no deseado cuando se desee salir 
                //del programa
                break;
                default:
                Console.WriteLine("Opción no valida!!");
                break;
            }

        }
        while(ejercicio != 100);

        Console.WriteLine("Ejecución de ejercicios terminada! \n");
    }

}

