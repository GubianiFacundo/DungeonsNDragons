using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Bolillero
    {
        private int cantidad;
        private int bolilla;
        private int[] bolillero;
        private Random numero = new Random();

        public Bolillero(int cantidad)
        {
            this.cantidad = cantidad;
            bolillero = new int[cantidad];
            for (int b = 0; b < cantidad; b++)
                bolillero[b] = b + 1; 

        }
        public int Extraer()
        {
            bolilla = -1;
            if (cantidad > 0)
            {
                int sorteo = numero.Next(cantidad);
                bolilla = bolillero[sorteo];
                cantidad--; 
                bolillero[sorteo] = bolillero[cantidad];
                
            }
            return bolilla; 
        }
    }
}
