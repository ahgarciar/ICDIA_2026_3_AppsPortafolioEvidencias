namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class OrdenamientoMascotaPorEdad : IComparer<Mascota>
{
    public int Compare(Mascota? x, Mascota? y)
    {
       int result =  x.Edad - y.Edad;
       return result;
    }
}