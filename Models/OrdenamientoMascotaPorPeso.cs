namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class OrdenamientoMascotaPorPeso : IComparer<Mascota>
{
    public int Compare(Mascota? x, Mascota? y)
    {
        int resultado = x.Peso.CompareTo(y.Peso);
        return resultado;
    }
}