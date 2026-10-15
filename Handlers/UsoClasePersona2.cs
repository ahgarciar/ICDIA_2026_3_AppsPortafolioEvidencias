using ICDIA_2026_3_AppsPortafolioEvidencias.Models;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class UsoClasePersona2
{
    public UsoClasePersona2()
    {
        Persona p1, p2, p3;
        p1 = new Persona("CURP", "JR", 21, "M");
        p2 = new Persona("GARA", "Alejandro G", 16, "M");
        p3 = new Persona("GATO", "Gato negro", 2, "F", "negro");
        //int calificacion = 10;
        
        
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        
        

    }
}