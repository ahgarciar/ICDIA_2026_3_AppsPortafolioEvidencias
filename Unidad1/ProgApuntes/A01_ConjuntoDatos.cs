namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad1.ProgsApuntes;

public class A01_ConjuntoDatos
{
    public int Id{get; set;}
    public string Nombre{get; set;}
    public int NumeroInstancias{get; set;}
    public int NumeroCaracteristicas{get; set;}

    public void Ejecutar()
    {
        A01_ConjuntoDatos iris = 
        new A01_ConjuntoDatos();
        iris.Id = 1;
        iris.Nombre = "iris";
        iris.NumeroInstancias = 150;
        iris.NumeroCaracteristicas = 4;
    }
}
