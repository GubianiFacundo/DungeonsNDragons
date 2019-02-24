using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Caballero: Ficha
    {
        public string nombre;
        public bool perdioTurno = false;

        public Caballero(string nombre) : base (false)
        { this.nombre = nombre; }

        public Caballero(int nro) : base (false)
        { this.nombre = "Pc " + nro; }

        public override int Mover()
        {
            Random R = new Random();
            int dado = R.Next(1,7);
            base.posicion+= dado;
            return dado;
        }
    }
}
