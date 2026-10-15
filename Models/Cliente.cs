namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class Cliente : Persona
{
    private int idCliente;
    private Mascota mascota;
    //private Image fotoMascota;
    private byte[] huella; 
    
    
    public Cliente(int idCliente, Mascota mascota,
        string curp, string nombre, int edad, string genero) 
        : base(curp, nombre, edad,genero) //constructor de la clase padre
    {
        this.idCliente = idCliente;
        this.mascota = mascota;
    }
    
    
    
}