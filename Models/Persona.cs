namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class Persona : IEquatable<Persona>
{
    //abstracción... - > 
    
    private string curp; //encapsulamiento
    private string nombre;
    private int edad;
    private string genero;
    private string colorfavorito;

    //Propiedad....
    public string Curp
    {
        get => curp; //consulta
       // set => curp = value; //modificacion
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }


    public Persona(string curp, string nombre, int edad, string genero, string colorfavorito)
    {
        this.curp = curp;
        this.nombre = nombre;
        this.edad = edad;
        this.genero = genero;
        this.colorfavorito = colorfavorito;
    }

    public Persona(string curp, string nombre, int edad, string genero)
    {
        this.curp = curp;
        this.nombre = nombre;
        this.edad = edad;
        this.genero = genero;
    }

    //Constructor vacio
    public Persona()
    {
        
    }

    public Persona(string curp)
    {
        this.curp = curp;
    }

    
    public bool Equals(Persona? other)
    {
        bool result = this.curp == other.curp;
        return result;
    }

    public override string ToString()
    {
        return "Persona: " + this.nombre + " ("+ curp + ")";
        
    }
}