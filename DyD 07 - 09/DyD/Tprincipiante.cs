using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Tprincipiante
    {
       public int nroJugadores;
       public static int limite = 50;
       public Caballero[] Jugadores;
       public int turno = 0;
       public bool hayGanador = false;
       public bool[] perdedores = { false, false, false, false };
       public string estado = "";
       public int play_fx = 0;  //-1 enemigo 
                                //0 nada
                                //1 aliado

        public Tprincipiante(int nroJugadores, string nombre)
        {
            Jugadores = new Caballero[nroJugadores];
            this.nroJugadores = nroJugadores;
            Jugadores[0] = new Caballero(nombre);
            for (int i = 1; i < nroJugadores; i++)
            {
                Jugadores[i] = new Caballero(i); 
            }
        }

        public virtual int Jugar()
        {
            int dado = 0;
            
            if (!Jugadores[turno].perdioTurno && !perdedores[turno])
                dado = Jugadores[turno].Mover();
           

            if (Jugadores[turno].posicion >= limite-1)
                hayGanador = true;

            turno++;
            if (turno == nroJugadores)
                turno = 0;


            return dado;
        }



    }
}
