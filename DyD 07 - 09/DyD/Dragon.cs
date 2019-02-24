using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Dragon: Ficha
    {
        public string dueño;
       static Random R = new Random(10);

        public Dragon(string dueño) : base(true)
        { this.dueño = dueño; }

        public Dragon(int nro) : base(true)
        { this.dueño = "Pc " + nro; }

        public override int Mover()
        {
            posicion = R.Next(Tprincipiante.limite);
            return posicion;
        }

       
    }
}
