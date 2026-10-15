namespace ICDIA_2026_3_AppsPortafolioEvidencias.Poligonos;

public class Cuadrado : Poligono
{
    private int lado;

    public int Lado
    {
        get => lado; 
        set => lado = value;
    }
    
    public Cuadrado(string name, int lado) : base(name)
    {
        Lado = lado;
    }
    
    public override double CalcularPerimetro()
    {
        Perimetro = Lado * 4;
        return Perimetro;
    }
}