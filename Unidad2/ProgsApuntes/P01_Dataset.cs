namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad2.ProgsApuntes;

public class P01_Dataset
{
    public int id;
    public string nombre;
    public int instancias;


    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value; 
    }

    public int Instancias
    {
        get => instancias;
        set => instancias = value;
    }

    public P01_Dataset()
    {
        
    }

    public P01_Dataset(int id, string nombre, int instancias)
    {
        Id = id;
        Nombre = nombre;
        Instancias = instancias;
    }

    public override string ToString()
    {
        return $"{Id} - {Nombre} - {Instancias} instancias";
    }

    public void Ejecutar()
    {        
        List<P01_Dataset> datasets = new List<P01_Dataset>();

        datasets.Add(new P01_Dataset(1, "Iris", 150));
        datasets.Add(new P01_Dataset(2, "Wine", 178));
        datasets.Add(new P01_Dataset(3, "Digits", 1797));

        while(true){

        Console.WriteLine("Que acción deseas ejecutar con la lista?:");
        Console.WriteLine("1.- Recorrer");
        Console.WriteLine("2.- Buscar");
        Console.WriteLine("3.- Eliminar");
        Console.WriteLine("4.- Filtrar");
        Console.WriteLine("5.- Ordenar");        

        int op = int.Parse(Console.ReadLine());

        Console.WriteLine("Aplicando acción: ->");

        switch (op)
        {
            case 1:
                Console.WriteLine("Recorrer");
            break;
            case 2:
                Console.WriteLine("Buscar");
            break;
            case 3:
                Console.WriteLine("Eliminar");
            break;
            case 4:
                Console.WriteLine("Filtrar");
            break;
            case 5:
                Console.WriteLine("Ordenar");
            break;
        }

}

    }
    

}