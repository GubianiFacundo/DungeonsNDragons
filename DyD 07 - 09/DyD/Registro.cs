using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Registro
    {
        int human = 0, pc = 0;

        public void AgregarGanador(int n) // 0 para humano 1 para pc
        {
            if (n == 0)
                human++;
            else if (n==1)
                pc++;
        }

        public string Fin()
        {
            return ("Has ganado en "+ Convert.ToString(human)+" ocasiones y la PC gano en " + Convert.ToString(pc) + " ocasiones.");
        }

    }
}
