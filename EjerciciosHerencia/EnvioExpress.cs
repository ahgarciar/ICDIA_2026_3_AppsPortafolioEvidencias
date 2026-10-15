namespace ICDIA_2026_3_ArqPatronesSoftware_Eq0.EjerciciosHerencia;

public class EnvioExpress : Envio
{
    public EnvioExpress(double peso, double distancia):
        base(peso, distancia) //Constructor de la clase padre
    {
        
    }

    public override double CalcularCostoEnvio()
    {
        return Peso * Distancia * 0.08 + 50;
    }
    
}