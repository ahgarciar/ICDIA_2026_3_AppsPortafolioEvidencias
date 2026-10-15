namespace ICDIA_2026_3_AppsPortafolioEvidencias.Poligonos;

public class Triangulo : Poligono
{
    private int altura;
    private int lado1; //base
    private int lado2;
    private int lado3;
    
    public Triangulo(string name, 
        int altura, int lado1, int lado2, int lado3) : base(name)
    {
        this.altura = altura;
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public override double CalcularPerimetro()
    {
        return this.lado1 + this.lado2 + this.lado3;
    }
}