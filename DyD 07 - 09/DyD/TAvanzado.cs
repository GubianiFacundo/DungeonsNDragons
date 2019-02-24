using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TAvanzado : TIntermedio
    {
        public Calabozo[] calabozos = new Calabozo[3];
        Bolillero bolillero = new Bolillero(Tprincipiante.limite-1);

        public TAvanzado(int nroJugadores, string nombre)
            : base(nroJugadores, nombre)
        {
            calabozos[0] = new Calabozo(bolillero.Extraer());
            calabozos[1] = new Calabozo(bolillero.Extraer());
            calabozos[2] = new Calabozo(bolillero.Extraer());
        }

        public override int Jugar()
        {
            int dado = base.Jugar();
             
              int turnoJugado = turno - 1;
            if (turnoJugado == -1)
                turnoJugado = nroJugadores - 1;

            CheckCalabozos(play_fx, turnoJugado);

            if (perdedores[turnoJugado] == true)
                estado = "Perdiste";

            return dado;
        }

        public void CheckCalabozos(int hayDragon,int turnoJugado)
        {
            if (Jugadores[turnoJugado].perdioTurno)
                Jugadores[turnoJugado].perdioTurno = false;
            else
            {

                switch (hayDragon)
                {
                    case -1:
                        if (Jugadores[turnoJugado].posicion + 5 == calabozos[0].posicion ||
                            Jugadores[turnoJugado].posicion + 5 == calabozos[1].posicion ||
                             Jugadores[turnoJugado].posicion + 5 == calabozos[2].posicion)
                        {
                            Jugadores[turnoJugado].posicion = Jugadores[turnoJugado].posicion + 5;
                            estado = "Perdiste";
                            perdedores[turnoJugado] = true; }
                           
                        break;
                    case 0:
                        if (Jugadores[turnoJugado].posicion == calabozos[0].posicion ||
                            Jugadores[turnoJugado].posicion == calabozos[1].posicion ||
                            Jugadores[turnoJugado].posicion == calabozos[2].posicion)
                        {
                            Jugadores[turnoJugado].perdioTurno = true;
                            estado = "Caiste en un calabozo, pierdes un turno";
                        }

                        break;
                    case 1:
                        if (Jugadores[turnoJugado].posicion - 5 == calabozos[0].posicion ||
                          Jugadores[turnoJugado].posicion - 5 == calabozos[1].posicion ||
                          Jugadores[turnoJugado].posicion - 5 == calabozos[2].posicion)
                        {
                            Jugadores[turnoJugado].posicion = Jugadores[turnoJugado].posicion - 5;
                            estado = "Caiste en un calabozo, caiste en un calabozo pero tu dragón te salvo";
                        }
                       break;
                }
            }

        }

    }
}
