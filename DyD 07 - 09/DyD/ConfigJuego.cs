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
    public partial class ConfigJuego : Form
    {
        public Registro regis = new Registro();
        Sonido sound = new Sonido();

        public ConfigJuego()
        {
            InitializeComponent();
        }

        private void ConfigJuego_Load(object sender, EventArgs e)
        {
            comboMapa.SelectedIndex = 0;
            nroOp.Value = 1;
        }

        public Form refForm1;

     
        private void labComenzar_MouseEnter(object sender, EventArgs e)
        {
            sound.fx_hover.PlayFromStart();
            labComenzar.ForeColor = System.Drawing.Color.White;
            labComenzar.Font = new Font("Mathematica6", 20);
        }

        private void labComenzar_MouseLeave(object sender, EventArgs e)
        {
            labComenzar.ForeColor = System.Drawing.Color.LightGray;
            labComenzar.Font = new Font("Mathematica6", 18);
        }

        private void labVolver_MouseEnter(object sender, EventArgs e)
        {
            sound.fx_hover.PlayFromStart();
            labVolver.ForeColor = System.Drawing.Color.White;
            labVolver.Font = new Font("Mathematica6", 20);
        }

        private void labVolver_MouseLeave(object sender, EventArgs e)
        {
            labVolver.ForeColor = System.Drawing.Color.LightGray;
            labVolver.Font = new Font("Mathematica6", 18);
        }

        private void labVolver_Click(object sender, EventArgs e)
        {
            sound.fx_back.PlayFromStart();
            refForm1.Visible = true;
            this.Close();
        }

        private void labComenzar_Click(object sender, EventArgs e)
        {
            FJuego fJuego = new FJuego();
            fJuego.reg = regis;
            sound.fx_click.PlayFromStart();
            fJuego.refForm1 = refForm1;
            fJuego.nombre = tbNombre.Text;
            fJuego.tipo = comboMapa.SelectedIndex;
            fJuego.nroJugadores = Convert.ToInt32(nroOp.Value+1);


            fJuego.Show();
            this.Close();
        }

        private void lbestadis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(regis.Fin());
        }



       
    }
}
