using ICDIA_2026_3_AppsPortafolioEvidencias.Models;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class UsoClasePersona3
{
    public UsoClasePersona3()
    {
        Persona p1, p2, p3;
        p1 = new Persona("CURP", "JR", 21, "M");
        p2 = new Persona("GARA", "Alejandro G", 16, "M");
        p3 = new Persona("GATO", "Gato negro", 2, "F", "negro");
        //int calificacion = 10;
        
        List<Persona> personas = new List<Persona>();
        personas.Add(p1);
        personas.Add(p2);
        personas.Add(p3);

        Console.WriteLine("Lista de personas registradas:--->");
        Console.WriteLine(" Lista tiene " + personas.Count + " personas");
        foreach (Persona p in personas)
        {
            Console.WriteLine(p);    
        }

        Console.WriteLine("\nOperaciones posibles: \n");
        int opcion;
        do
        {
            Console.WriteLine(" 1. Seleccionar una persona");
            Console.WriteLine(" 2. Salir\n");
            opcion = int.Parse(Console.ReadLine());
            //opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el CURP de la Persona a consultar: ");
                    string curp = Console.ReadLine();
                    //validar que el curp sea valido!
                    //
                    Persona auxiliar = new Persona(curp);
                    bool result = personas.Contains(auxiliar);
                    Console.WriteLine("RESULTADO DE LA BUSQUEDA :");
                    Console.WriteLine(result.Equals(true)? "Existe": "No existe");
                    int seleccion;
                    if (result) //result == true
                    {
                        do
                        {
                            Console.WriteLine("Selecciona una opción a consultar:");
                            Console.WriteLine("1.- CURP");
                            Console.WriteLine("2.- NOMBRE");
                            Console.WriteLine("3.- EDAD");
                            Console.WriteLine("4.- GENERO");
                            Console.WriteLine("5.- COLOR FAVORITO");
                            Console.WriteLine("6.- SALIR");
                            seleccion = int.Parse(Console.ReadLine());

                            int index_persona = personas.IndexOf(auxiliar);
                            
                            //obtencion de la referencia de memoria
                            Persona temporal = personas[index_persona];
                            
                            switch (seleccion)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    int edad = temporal.Edad;
                                        Console.WriteLine("Edad de la persona: " + edad);
                                    Console.WriteLine("Desea cambiar la iedad registrada? (1 = si, 0 = no)");
                                    int resultado = Convert.ToInt32(Console.ReadLine());
                                    if (resultado == 1)
                                    {
                                        Console.WriteLine("Cuál es la nueva edad? ");
                                        edad = Convert.ToInt32(Console.ReadLine());
                                        temporal.Edad = edad; //set
                                        Console.WriteLine("Edad actualizada! :D!");
                                    }
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    Console.WriteLine("Proceso de revisión de la persona seleccionada terminado");
                                    break;
                                default:
                                    Console.WriteLine("Opción no valida");
                                    break;
                            }
                        } while (seleccion!=6);
                    }
                    break;
                case 2:
                    Console.WriteLine("Gracias por usar este programa!");
                    break;
                default:
                    Console.WriteLine("Opción no valida :(, intente de nuevo! >.<");
                    break;
            }
        } while (opcion != 2);



    }
}