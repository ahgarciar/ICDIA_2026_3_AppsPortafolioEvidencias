namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class OrdenamientoMascotaPorGenero : IComparer<Mascota>
{
    public int Compare(Mascota? x, Mascota? y)
    {
        return x.Genero.CompareTo(y.Genero);
    }
}