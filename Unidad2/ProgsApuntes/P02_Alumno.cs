namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes;

public class Alumno {
    private string nombre; //campo 

    public string Nombre { //Propiedad
        get => nombre; //recuperacion / consulta
        set{ //asignacionde un valor al campo

            //validacion
            if (string.IsNullOrWhiteSpace(value)){
                    //Detiene la ejecucion del programa y lanza una excepcion 
                    throw new ArgumentException("El nombre no puede estar vacío.");
            }

            //if() //validacion para determinar si contiene numeros
                //throw new ArgumentException("El nombre no puede contener numeros)

            //Si se llego aqui significa que el valor es valido y se asigna al campo
            nombre = value;

        }
    }

    public double CalcularPromedio(List<double> valores) {
        
        //comprueba que la lista este instanciada
        if (valores == null){
            throw new ArgumentNullException(nameof(valores));
        }

        //la lista tiene agregados valores
        if (valores.Count == 0){
            throw new ArgumentException("La lista no puede estar vacía.");
        }

        //la lista esta instanciada y al menos tiene un valor agregado

        //calcular y devolver el promedio
        return valores.Average();

    }

}