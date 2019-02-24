using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FJuego : Form
    {
        Sonido sound = new Sonido();
        public Registro reg = new Registro();
        public FJuego()
        {
            InitializeComponent();
        }

        public string nombre;
        public int tipo;
        public int nroJugadores;

        Tprincipiante tablero;
        public Form refForm1;

        public void btnTirar_Click(object sender, EventArgs e)
        {
             // sound.fx_flecha.PlayFromStart();

            int dado = tablero.Jugar();
            if (dado != 0)
                lbDado.Text = dado.ToString();
            else
                lbDado.Text = "Perdio Turno";

            string item;
            int ganador = -1;
            
            int turnoJugado=0;

            lbTurno.Text = tablero.Jugadores[tablero.turno].nombre;

            if (tablero.turno == 0)
                turnoJugado= tablero.nroJugadores - 1;
            else
                turnoJugado= tablero.turno - 1;

            if (tablero.perdedores[turnoJugado] == true)
                item = "Pc 2 Perdio";
            else
            {
                item = tablero.Jugadores[turnoJugado].nombre + "--- Posicion: " + (tablero.Jugadores[turnoJugado].posicion + 1);
                item += "   " + tablero.estado;
            }
          
            ActualizarLabPosiciones(nroJugadores);
            ActualizarLabDragones(nroJugadores, tipo);

            if (tablero.play_fx == 1)
                sound.fx_aliado.PlayFromStart();
            else if (tablero.play_fx == -1)
                 sound.fx_enemigo.PlayFromStart();

            if (tablero.hayGanador)
                ganador = turnoJugado;
         

            

            DialogResult result = DialogResult.Abort;
            if (ganador != -1)
            {
                sound.fx_ganador.PlayFromStart();
                result = MessageBox.Show("--- Ganó: " + tablero.Jugadores[ganador].nombre+" ---");
                reg.AgregarGanador(ganador);
            }
           
               

            if (result == DialogResult.OK)
            {
                ConfigJuego config = new ConfigJuego();
                
                config.refForm1 = refForm1;
                config.Show();
                this.Close();
            }



            listJuego.Items.Add(item);
            listJuego.SelectedIndex = listJuego.Items.Count - 1;
        }

        private void FJuego_Load(object sender, EventArgs e)
        {
            lbTurno.Text = nombre;
            lbNombre.Text = nombre;
           
            switch (tipo)
            {
                case 0:
                    tablero= new Tprincipiante(nroJugadores, nombre);
                    break;
                case 1:
                    tablero = new TIntermedio(nroJugadores, nombre);        
                    break;
                case 2:
                    tablero = new TAvanzado(nroJugadores, nombre);
                    break;
            }

            ActualizarLabPosiciones(nroJugadores);
            ActualizarLabDragones(nroJugadores, tipo);
            ActualizarLabCalabozos(tipo);
        }

        private void FJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigJuego config = new ConfigJuego();
            config.refForm1 = refForm1;
            config.regis = reg;
            config.Show();
        }

        public void ActualizarLabPosiciones(int nroJugadores)
        {
            lbP0.Text = (tablero.Jugadores[0].posicion+1).ToString();
            lbP1.Text = (tablero.Jugadores[1].posicion+1).ToString();
            if(nroJugadores>=3)
                lbP2.Text = (tablero.Jugadores[2].posicion+1).ToString();
            if(nroJugadores==4)
                lbP3.Text = (tablero.Jugadores[3].posicion+1).ToString();
        }

        public void ActualizarLabDragones(int nroJugadores,int tipo)
        {
            if (tipo > 0)
            { 
                lbD0.Text = (((TIntermedio)tablero).dragones[0].posicion + 1).ToString() +"---"+ (((TIntermedio)tablero).dragones[1].posicion + 1).ToString();
                lbD1.Text = (((TIntermedio)tablero).dragones[2].posicion + 1).ToString() + "---" + (((TIntermedio)tablero).dragones[3].posicion + 1).ToString();
                 if (nroJugadores >= 3)
                     lbD2.Text = (((TIntermedio)tablero).dragones[4].posicion + 1).ToString() + "---" + (((TIntermedio)tablero).dragones[5].posicion + 1).ToString();
                 if (nroJugadores == 4)
                     lbD3.Text = (((TIntermedio)tablero).dragones[6].posicion + 1).ToString() + "---" + (((TIntermedio)tablero).dragones[7].posicion + 1).ToString();
             }
        }

        public void ActualizarLabCalabozos(int tipo)
        {
            if (tipo == 2)
            {
                labC.Text = (((TAvanzado)tablero).calabozos[0].posicion + 1) + "---" + (((TAvanzado)tablero).calabozos[1].posicion + 1) + "---" + (((TAvanzado)tablero).calabozos[2].posicion + 1);
            }
        }

    }
}
