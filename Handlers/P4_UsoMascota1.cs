using ICDIA_2026_3_AppsPortafolioEvidencias.Models;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class P4_UsoMascota1
{
    public P4_UsoMascota1()
    {
        //Logica de la funcionalidad del programa!

        List<Mascota> mascotas; //declarando
        mascotas = new List<Mascota>(); //instancia


        mascotas.Add(new Mascota(3, "Peluchon", 7, 20, true, false));
        mascotas.Add(new Mascota(4, "Gasper", 4, 16, true, true));
        mascotas.Add(new Mascota(1, "Felipe", 3, 3.5, true, true));
        mascotas.Add(new Mascota(2, "Benito", 5, 16, true, true));
        mascotas.Add(new Mascota(5, "Grace", 3, 4, false, true));
        mascotas.Add(new Mascota(8, "Igby", 7, 5, true, true));
        mascotas.Add(new Mascota(9, "Simba", 4, 7, true, true));
        mascotas.Add(new Mascota(6, "Wilson", 7, 6, true, false));
        mascotas.Add(new Mascota(7, "Minerva", 9, 6, false, true));
        mascotas.Add(new Mascota(10, "Morita", 2, 2, false, true));

        Console.WriteLine("Lista de mascotas con id y nombre: \n");
        foreach (Mascota mascota in mascotas)
        {
            Console.WriteLine(mascota);
            Console.WriteLine("Edad: " + mascota.Edad);
            Console.WriteLine("Peso: " + mascota.Peso);
            Console.WriteLine("Genero: " + (mascota.Genero == true ? "Macho" : "Hembra"));
            Console.WriteLine("Estado de vacunación: " + (mascota.EstaVacunado == true ? "" : "No ") + "Vacunado");
            Console.WriteLine("");
        }

        Console.WriteLine("\n\nMascotas que no han sido vacunadas: \n");
        foreach (Mascota mascota in mascotas) //busqueda secuencial 
        {
            if (!mascota.EstaVacunado)
            {
                Console.WriteLine(mascota);
                Console.WriteLine("Edad: " + mascota.Edad);
                Console.WriteLine("Peso: " + mascota.Peso);
                Console.WriteLine("Genero: " + (mascota.Genero == true ? "Macho" : "Hembra"));
                Console.WriteLine("");
            }
        }

        int idMascota_a_buscar = 5;

        Console.WriteLine("\n\nBuscar elemento en la lista:");
        Mascota aux = new Mascota(idMascota_a_buscar);
        bool mascotaExiste = mascotas.Contains(aux);
        Console.WriteLine("La mascota con ID " + idMascota_a_buscar + ", " + (mascotaExiste ? "E" : "No e") + "xiste");

        Console.WriteLine("\n\nObtener el índice del elemento en la lista:");
        aux = new Mascota(idMascota_a_buscar);
        int indice = mascotas.IndexOf(aux);
        Console.WriteLine("La mascota con ID " + idMascota_a_buscar + " se encuentra en el índice: " + indice);


        Console.WriteLine("\n\nLista ordenada por id:\n");
        mascotas.Sort();
        foreach (Mascota mascota in mascotas)
        {
            Console.WriteLine(mascota);
            Console.WriteLine("Edad: " + mascota.Edad);
            Console.WriteLine("Peso: " + mascota.Peso);
            Console.WriteLine("Genero: " + (mascota.Genero == true ? "Macho" : "Hembra"));
            Console.WriteLine("Estado de vacunación: " + (mascota.EstaVacunado == true ? "" : "No ") + "Vacunado");
            Console.WriteLine("");
        }

        Console.WriteLine("\n\nLista ordenada por EDAD:\n");
        mascotas.Sort(new OrdenamientoMascotaPorEdad());
        foreach (Mascota mascota in mascotas)
        {
            Console.WriteLine(mascota);
            Console.WriteLine("Edad: " + mascota.Edad);
            Console.WriteLine("Peso: " + mascota.Peso);
            Console.WriteLine("Genero: " + (mascota.Genero == true ? "Macho" : "Hembra"));
            Console.WriteLine("Estado de vacunación: " + (mascota.EstaVacunado == true ? "" : "No ") + "Vacunado");
            Console.WriteLine("");
        }
    
        Console.WriteLine("\n\nLista ordenada por NOMBRE:\n");
        mascotas.Sort(new OrdenamientoMascotaPorNombre());
        foreach (Mascota mascota in mascotas)
        {
            Console.WriteLine(mascota);
            Console.WriteLine("Edad: " + mascota.Edad);
            Console.WriteLine("Peso: " + mascota.Peso);
            Console.WriteLine("Genero: " + (mascota.Genero==true ? "Macho" : "Hembra"));
            Console.WriteLine("Estado de vacunación: " + (mascota.EstaVacunado == true ? "" : "No ") + "Vacunado");
            Console.WriteLine("");
        }
        
        Console.WriteLine("\n\nLista ordenada por Edad y Peso:\n");
        mascotas.Sort(new OrdenamientoMascotaPorEdadPeso());
        foreach (Mascota mascota in mascotas)
        {
            Console.WriteLine(mascota);
            Console.WriteLine("Edad: " + mascota.Edad);
            Console.WriteLine("Peso: " + mascota.Peso);
            Console.WriteLine("Genero: " + (mascota.Genero==true ? "Macho" : "Hembra"));
            Console.WriteLine("Estado de vacunación: " + (mascota.EstaVacunado == true ? "" : "No ") + "Vacunado");
            Console.WriteLine("");
        }



}
}