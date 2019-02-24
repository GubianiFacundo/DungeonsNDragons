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
    public partial class FSplash : Form
    {
        String[] FrasesCarga = {"Generando Caballeros", "Creando Dragones", "Forjando Espadas", "Construyendo Calabozos" };
        int count = 0;
        int progress = 0;

       

        

        public FSplash()
        {
            InitializeComponent();      
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;
            if (progress % 19 == 0)
            {
                labCarga.Text = FrasesCarga[count];
                count++;
                if (count == FrasesCarga.Length)
                    count--;
            }

            if (progress == 100)
            {
                timer1.Stop();
                this.Close();
            }
     
        }

        private void FSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
