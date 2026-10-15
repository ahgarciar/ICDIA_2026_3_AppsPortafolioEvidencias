using ICDIA_2026_3_AppsPortafolioEvidencias.Models;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class P5_UsoClasePersonaMascota
{

    public P5_UsoClasePersonaMascota()
    {

        Cliente cliente = new Cliente(
            1,
            new Mascota(1, "Peluchon", 7, 20, true, false),
            "MPUI", "Alejandro", 21, "H");
        
        

    }

}