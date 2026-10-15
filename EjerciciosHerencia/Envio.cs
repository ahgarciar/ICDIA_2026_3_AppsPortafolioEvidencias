namespace ICDIA_2026_3_ArqPatronesSoftware_Eq0.EjerciciosHerencia;

public class Envio
{
    private double peso;
    private double distancia;

    public double Peso
    {
        get => peso;
        set => peso = value;
    }

    public double Distancia
    {
        get => distancia;
        set => distancia = value;
    }

    public Envio(double peso, double distancia)
    {
        this.peso = peso;
        this.distancia = distancia;
    }

    public virtual double CalcularCostoEnvio()
    {
        return 0;
    }
}