using ICDIA_2026_3_AppsPortafolioEvidencias.EjerciciosExcepciones;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class P7_UsoCarros
{
    public P7_UsoCarros()
    {
        try
        {
            Carro carrito1;
            Carro carrito2;
            carrito1 = new Carro("Gatito", "", "", 0);
            Console.WriteLine();
        }
        catch (ArgumentException ex) {
            Console.WriteLine("Ocurrio un error en el argumento");
        }
        catch (FormatException ex)  {
            Console.WriteLine("Ocurrio un error en el formato");
        }
        catch (Exception ex) {
            Console.WriteLine("Ocurrio un error!.");
        }

    }
}