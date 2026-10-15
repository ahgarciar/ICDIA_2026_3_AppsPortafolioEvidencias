namespace ICDIA_2026_3_ArqPatronesSoftware_Eq0.EjerciciosHerencia;

public class EmpleadoConBono : Empleado
{
    //Requiere el bono que se aplicara
    private double bono;

    public EmpleadoConBono(string nombre, double sueldobase, double bono) : 
        base(nombre, sueldobase)
    {
        this.bono = bono;
    }

    public virtual double CalcularPago()
    {
        return Sueldobase + bono;
    }

}