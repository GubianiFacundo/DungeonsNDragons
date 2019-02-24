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
    public partial class Demo2 : Form
    {
        public Demo2()
        {
            InitializeComponent();
        }

        Tprincipiante[] tableros = new Tprincipiante[3];


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Demo2_Load(object sender, EventArgs e)
        {
            tableros[0] = new Tprincipiante(3, "Pc 0");
            tableros[1] = new TIntermedio(3, "Pc 0");
            tableros[2] = new TAvanzado(3, "Pc 0");
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            int turnoJugado = 0;
            ListBox[] listita = { listBox1, listBox2, listBox3 };
            Label[] misLabels = { lbP, lbI, lbA };

            for (int i = 0; i < 3; i++)
            {
                while (!tableros[i].hayGanador)
                {
                    tableros[i].Jugar();
                    turnoJugado = tableros[i].turno - 1;
                    if (turnoJugado == -1)
                        turnoJugado = tableros[i].nroJugadores - 1;
                    string item = tableros[i].Jugadores[turnoJugado].nombre + " posición " + (tableros[i].Jugadores[turnoJugado].posicion + 1);
                    listita[i].Items.Add(item);
                    listita[i].SelectedIndex = listita[i].Items.Count - 1;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                }
                
                misLabels[i].Text = tableros[i].Jugadores[turnoJugado].nombre;
            }
        }
    }
}
