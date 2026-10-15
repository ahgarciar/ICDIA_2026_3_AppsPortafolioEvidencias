namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class OrdenamientoMascotaPorNombre : IComparer<Mascota>
{
    public int Compare(Mascota? x, Mascota? y)
    {
        int result = x.Nombre.CompareTo(y.Nombre);
        return result;
    }
}