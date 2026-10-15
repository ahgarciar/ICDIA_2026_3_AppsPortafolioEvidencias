namespace ICDIA_2026_3_ArqPatronesSoftware_Eq0.EjerciciosHerencia;

public class EnvioEstandar : Envio
{

    public EnvioEstandar(double peso, double distancia) :
        base(peso, distancia)
    {
        
    }

    public override double CalcularCostoEnvio()
    {
        return Peso * Distancia * 0.05;
    }

}