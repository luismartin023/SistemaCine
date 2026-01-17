using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCine
{
    public class Cine
    {
        private int contarpersonas;
        private int capacidadmaxima;
        private int entradasVendidas;
        private int precioEntrada = 100;

        public Cine(int capacidad)
        {
            this.capacidadmaxima = capacidad;
            this.contarpersonas = 0;
            this.entradasVendidas = 0;
        }
        public void venderTaquilla()
        {
            if (contarpersonas < capacidadmaxima)
            {
                contarpersonas++;      
                entradasVendidas++;   
                Console.WriteLine($"Venta realizada. Asiento ocupado. Precio: RD${precioEntrada}");
            }
            else
            {
                Console.WriteLine("¡La sala está llena! No se puede vender más.");
            }
        }

        public void verAforo()
        {
            int libres = capacidadmaxima - contarpersonas;

            double porcentaje = ((double)contarpersonas / capacidadmaxima) * 100;

            Console.WriteLine($"Estado del Cine");
            Console.WriteLine($"Asientos Usados: {contarpersonas} personas");
            Console.WriteLine($"Asientos Disponibles: {libres} asientos");
            Console.WriteLine($"Estado de sala: {porcentaje:F1}%"); 
            Console.WriteLine($"Total vendido: RD${entradasVendidas * precioEntrada}");
        }

        public void sacarPersonas()
        {
            if (contarpersonas > 0)
            {
                contarpersonas--; 
                             
                Console.WriteLine("Una persona ha salido de la sala.");
            }
            else
            {
                Console.WriteLine("La sala ya está vacía.");
            }
        }

    }
}
