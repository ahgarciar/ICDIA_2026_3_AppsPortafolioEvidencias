namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes;

public class ModeloML{
    private double precision; //campo

    public double Precision { //Propiedad
        get => Math.Round(precision * 100, 4); // consulta
        set {
                if (value < 0 || value > 1) {
                    throw new ArgumentOutOfRangeException(nameof(value), 
                    "La precisión debe estar entre 0 y 1.");
                }

                precision = value;

            }
 
    }

 }