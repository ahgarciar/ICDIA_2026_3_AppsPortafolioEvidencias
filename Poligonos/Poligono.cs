namespace ICDIA_2026_3_AppsPortafolioEvidencias.Poligonos;

public class Poligono
{
    private string name;
    private double perimetro;
    private double area;

    public double Perimetro { get; set; }

    public double Area { get; set; }
    
    public Poligono(string name)
    {
        this.name = name;
    }

    public Poligono(string name, double perimetro, double area)
    {
        this.name = name;
        this.perimetro = perimetro;
        this.area = area;
    }

    public double CalcularArea()
    {
        return area;
    }

    public virtual double CalcularPerimetro()
    {
        throw new NotImplementedException();    }

}