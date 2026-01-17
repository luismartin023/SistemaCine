using System;

namespace SistemaCine
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Cine miCine = new Cine(10);

            miCine.venderTaquilla();
            miCine.verAforo();
            miCine.sacarPersonas();

            bool continuar = true;
    
            while (continuar)
            {
                Console.Clear(); 
                Console.WriteLine("BIENVENIDO A CINEMAX UCE"); 

                Console.WriteLine("1. Vender Taquilla");
                Console.WriteLine("2. Ver Aforo (Estado de la sala)");
                Console.WriteLine("3. Sacar Persona (Salida)");
                Console.WriteLine("4. Salir del Sistema");

                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                Console.WriteLine(); 

            
            switch (opcion)
            {
                case "1":
                    miCine.venderTaquilla();
                    break;

                case "2":
                    miCine.verAforo();
                    break;

                case "3":
                    miCine.sacarPersonas();
                    break;

                case "4":
                    continuar = false;
                    Console.WriteLine("Cerrando el sistema...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            
            }
        }
    }
}