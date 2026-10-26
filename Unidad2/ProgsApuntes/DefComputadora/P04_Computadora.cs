namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes.DefComputadora;

public class Computadora
{
    string nombre;
    Monitor monitor;
    Mouse mouse;

    public string Nombre
    {
        get=> nombre;
        set=> nombre = value; 
    }

    public Monitor MonitorC
    {
        get => monitor;
        set => monitor = value;
    }

    public Mouse MouseC
    {
        get => mouse;
        set => mouse = value;
    }

    public Computadora(string nombre)
    {
        Nombre = nombre;
        MonitorC = null;
        MouseC = null;
    }

}