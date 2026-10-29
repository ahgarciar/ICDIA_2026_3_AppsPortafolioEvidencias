namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes;

public class AlumnoCalificacion
{
    private string nombre;
    private int calificacion;

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Calificacion
    {
        get => calificacion;
        set => calificacion = value;
    }

    public AlumnoCalificacion(string nombre, int calificacion)
    {
        Nombre = nombre;
        Calificacion = calificacion;
    }

    public override string ToString()
    {
        return "Nombre: " + Nombre + "\t Calificación: "+ Calificacion;
    }


}