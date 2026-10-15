
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

        #region Introduccion
        //UsoClasePersona1 programa;
        //programa = new UsoClasePersona1();

        //new UsoClasePersona2();

        //new UsoClasePersona3();

        //new P4_UsoMascota1();

        //new P6_UsoPoligonos1();

       //new P7_UsoCarros();
        
     //   new R03_CarroManual();

     #endregion
    
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
        Console.WriteLine("2: ");
        Console.WriteLine("3: ");
        Console.WriteLine("4: ");
        Console.WriteLine("5: ");
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
                    Console.WriteLine("Ejecución del apunte 2");
                break;
                case 3:
                    Console.WriteLine("Ejecución del apunte 3");
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

