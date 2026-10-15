using ICDIA_2026_3_AppsPortafolioEvidencias.Models;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class UsoClasePersona1
{
    public UsoClasePersona1()
    {
        //Tipo de dato abstracto

        //string nombre; //primitivo

        //opcion 1
        Persona persona; // Declración
        persona = new Persona(); //instanciacion
        
        //Opcion 2
        Persona pp = new Persona(); //declaracion e instanciacion en una sola linea
        
        //Asignacion 
        // La asignación se puede realizar al momento de instanciar un objeto
        //o se puede realizar despues de haberlo instanciado
        
        //Cuando se realiza al momento de instacniar, se hace uso de un método 
        //especial que lleva de nombre "constructor"
        
        //Cuando se realiza despues de la instanciacion, entonces
        //la recomendacion es utilizar propiedades (getters/setters)
        
    }
}