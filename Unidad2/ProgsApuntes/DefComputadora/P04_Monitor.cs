namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes.DefComputadora;

public class Monitor
{
    
    public string marca;
    public double pulgadas;

    public String Marca
    {
        get => marca;
        set => marca = value;
    }

    public double Pulgadas
    {
        get => pulgadas;
        set => pulgadas = value;
    }

    public Monitor(string marca, double pulgadas)
    {
        Marca = marca;
        Pulgadas = pulgadas;
    }


}