namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class OrdenamientoMascotaPorEdadPeso : IComparer<Mascota>
{
    public int Compare(Mascota? x, Mascota? y)
    {
        int resultado_Edad = x.Edad - y.Edad;
        
        if (resultado_Edad == 0)
        {
            int resultado_Peso = x.Peso.CompareTo(y.Peso);
            return resultado_Peso;
        }
        
        return resultado_Edad;
        
    }
}