using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TIntermedio: Tprincipiante
    {
        public Dragon[] dragones;
      

        public TIntermedio(int nroJugadores, string nombre)
            : base(nroJugadores, nombre)
        {
            dragones = new Dragon[nroJugadores * 2];

            dragones[0] = new Dragon(Jugadores[0].nombre);
            dragones[1] = new Dragon(Jugadores[0].nombre);

            for (int i = 1; i < base.Jugadores.Length; i++)
            {

                dragones[i*2] = new Dragon(i);
                dragones[i*2 + 1] = new Dragon(i);
            }
        }

         public override int Jugar()
        {
           int dado= base.Jugar();
            int turnoJugado = turno - 1;
            if (turnoJugado == -1)
                turnoJugado = nroJugadores - 1;

            estado = "";
            play_fx = 0;

             play_fx=CheckDragones(turnoJugado);

            switch (play_fx)
            { 
                case -1:
                    estado = "Te encontraste con un dragon enemigo";
                    break;
                case 0:

                    break;
                case 1:
                    estado = "Te encontraste con un dragon aliado";
                    break;
            }

            if(Jugadores[turnoJugado].posicion > limite)
                hayGanador= true;

            MoverDragones(turnoJugado);

            return dado;
        }

        public int CheckDragones(int nroJugador)
        {
            for (int i = 0; i < dragones.Length; i++)
            {
                if (Jugadores[nroJugador].posicion == dragones[i].posicion)
                {
                    if (Jugadores[nroJugador].nombre.Equals(dragones[i].dueño))
                    {
                        Jugadores[nroJugador].posicion += 5;
                        dragones[i].posicion += 5;

                        return 1;
                    }
                    else
                    {
                        if (Jugadores[nroJugador].posicion>=5)
                        Jugadores[nroJugador].posicion -= 5;
                        else
                            Jugadores[nroJugador].posicion=0;

                        return -1;
                    }
                }
            }

            return 0;
        }

        public void MoverDragones(int nroJugador)
        { 
            dragones[nroJugador*2].Mover();
            dragones[nroJugador * 2 + 1].Mover();    
        }
    }
}
