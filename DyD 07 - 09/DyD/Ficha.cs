using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    abstract class Ficha
    {
        public int posicion;
        static Random R = new Random();
        public abstract int Mover();

        public Ficha(bool esAleatorio) 
        {
       
            if (esAleatorio)
                posicion = R.Next(50);
            else
                posicion = 0;
        }


    }
}
