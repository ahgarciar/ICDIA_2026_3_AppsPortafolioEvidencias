namespace ICDIA_2026_3_AppsPortafolioEvidencias.Models;

public class Mascota : IEquatable<Mascota>, IComparable<Mascota>
{
    private int idMascota;
    private string nombre;
    private int edad;
    private double peso;
    private bool genero;
    private bool estaVacunado;

    #region PROPIEDADES
    
    public int IdMascota
    {
        get => idMascota;
        set => idMascota = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    public double Peso
    {
        get => peso;
        set => peso = value;
    }

    public bool Genero
    {
        get => genero;
        set => genero = value;
    }

    public bool EstaVacunado
    {
        get => estaVacunado;
        set => estaVacunado = value;
    }
    
    #endregion
    
    #region Constructores

        public Mascota()
        {
        }

        public Mascota(int idMascota)
        {
            this.idMascota = idMascota;
        }

        public Mascota(int idMascota, string nombre, int edad, double peso, bool genero, bool estaVacunado)
        {
            this.idMascota = idMascota;
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.genero = genero;
            this.estaVacunado = estaVacunado;
        }

    #endregion

    #region MetodoEquals_Compare

        public bool Equals(Mascota? other)
        {
            return IdMascota == other.IdMascota;
        }
        
        /*
         * ORDENAMIENTO DE OBJETOS...
         * 1.- NATURAL.... (IDENTIFICADOR DE OBJETO)
         *      DEBE SER CONGRUENTE CON EL MÉTODO DE COMPARACIÓN (EQUALS)
         *          CUANOD EQUALS DEVUELVE TRUE, EL ORDENAMIENTO DEBE DEVOLVER "0"
         * 2.- POR OTROS ATRIBUTOS....
        */
        
        public int CompareTo(Mascota? other)
        {
            return this.IdMascota - other.IdMascota;
        }

    #endregion

    #region MetodosFuncionales

    
    #endregion
    
    public override string ToString()
    {
        return "Mascota [" + this.IdMascota + "] - " + Nombre;
    }
}