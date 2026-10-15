using ICDIA_2026_3_AppsPortafolioEvidencias.Poligonos;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class P6_UsoPoligonos1
{
    public P6_UsoPoligonos1()
    {
        Poligono poligono1;
        Poligono poligono2;
        Cuadrado cuadrado2;

        cuadrado2 = new Cuadrado("cuadradito2", 5);
        poligono1 = new Cuadrado("cuadrito1", 3);
        poligono2 = new Triangulo("triangulito1", 5, 3, 4, 4);
        
        double perimetro_cuadrado2 = cuadrado2.CalcularPerimetro();
        Console.WriteLine("El perimetro es: " + perimetro_cuadrado2);
        
        double perimetro_poligono1 = poligono1.CalcularPerimetro();
        Console.WriteLine("El perimetro es: " + perimetro_poligono1);
        
        double perimetro_poligono2 = poligono2.CalcularPerimetro();
        Console.WriteLine("El perimetro es: " + perimetro_poligono2);
        
        //poligono1.

    }

}