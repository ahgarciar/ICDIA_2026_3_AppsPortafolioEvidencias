namespace ICDIA_2026_3_AppsPortafolioEvidencias.EjerciciosExcepciones;

public class Carro
{
    private string owner;
    private string marca;
    private string linea;
    private int modelo;

    public string Owner
    {
        get => owner;
        set
        {
            if (value.Equals("")) 
                throw new ArgumentException("Owner must be a valid owner name.");
            
            owner = value;
            
        }
    }

    public string Marca
    {
        get => marca; 
        set => marca = value;
    }

    public string Linea
    {
        get => linea; 
        set => linea = value;
    }

    public int Modelo
    {
        get => modelo;
        set
        {
            if (value < 1900 || value > 2100)
                //throw new ArgumentException("Modelo must be between 1900 and 2100.");
                throw new FormatException("Invalid model.");
            //throw new 
                
            modelo = value;
        }
    }
    
    public Carro(string owner, string marca, string linea, int modelo)
    {
        Owner = owner;
        Marca = marca;
        Linea = linea;
        Modelo = modelo;
    }

    public virtual void Arrancar()
    {
        
    }

}