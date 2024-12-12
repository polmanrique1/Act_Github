using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Cotxe vehicle1 = new Cotxe("Subaru", "Kla", 2000, 120.0, 4);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe vehicle2 = new Cotxe("Volvobagen", "Kai", 1995, 240.0, 4);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();
    }
}
