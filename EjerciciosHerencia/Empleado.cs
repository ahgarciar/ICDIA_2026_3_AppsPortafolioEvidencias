namespace ICDIA_2026_3_ArqPatronesSoftware_Eq0.EjerciciosHerencia;

public class Empleado
{
    private string nombre;
    private double sueldobase;

    public Empleado(string nombre, double sueldobase)
    {
        this.nombre = nombre;
        this.sueldobase = sueldobase;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre= value;
    }

    public double Sueldobase
    {
        get => sueldobase;
        set => sueldobase = value;
    }

    public virtual double CalcularPago()
    {
        return 0;
    }
    
}