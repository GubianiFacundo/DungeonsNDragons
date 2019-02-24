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
    public partial class Form1 : Form
    {
        public Registro unreg = new Registro();
        FSplash Splash;
        Sonido sound = new Sonido();
        bool playing = true;

        static string path = @"C:\Users\SAMSUNG\Downloads\DyD 06_09\DyD\Resources";

       System.Media.SoundPlayer player = new System.Media.SoundPlayer(path+@"\got.wav");
        

        public Form1()
        {
            InitializeComponent();
           // player.PlayLooping();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             Splash = new FSplash();
            Splash.ShowDialog();     
        }

    
        private void labJugar_MouseLeave(object sender, EventArgs e)
        {
            labJugar.ForeColor = System.Drawing.Color.LightGray;
            labJugar.Font = new Font("Mathematica6", 18);
        }

        private void labJugar_MouseEnter(object sender, EventArgs e)
        {
            sound.fx_hover.PlayFromStart();
            labJugar.ForeColor = System.Drawing.Color.White;
            labJugar.Font = new Font("Mathematica6", 20);
        }

        private void labSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labDemo_MouseEnter(object sender, EventArgs e)
        {
            sound.fx_hover.PlayFromStart();
            labDemo.ForeColor = System.Drawing.Color.White;
            labDemo.Font = new Font("Mathematica6", 20);
        }

        private void labDemo_MouseLeave(object sender, EventArgs e)
        {
            labDemo.ForeColor = System.Drawing.Color.LightGray;
            labDemo.Font = new Font("Mathematica6", 18);
        }

        private void labSalir_MouseEnter(object sender, EventArgs e)
        {
            sound.fx_hover.PlayFromStart();
            labSalir.ForeColor = System.Drawing.Color.White;
            labSalir.Font = new Font("Mathematica6", 20);
        }

        private void labSalir_MouseLeave(object sender, EventArgs e)
        {
            labSalir.ForeColor = System.Drawing.Color.LightGray;
            labSalir.Font = new Font("Mathematica6", 18);
        }

        private void labJugar_Click(object sender, EventArgs e)
        {
            
            ConfigJuego FConfig = new ConfigJuego();
            FConfig.regis = unreg;
            sound.fx_click.PlayFromStart();
            FConfig.refForm1 = this;
            FConfig.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                pictureBox1.Image = Properties.Resources.musicOFF;
                playing = false;
                player.Stop();
            }
            else 
            {
                pictureBox1.Image = Properties.Resources.musicON;
                playing = true;
                player.PlayLooping();
            }
         
        }

        private void labDemo_Click(object sender, EventArgs e)
        {
            Demo2 miDemo = new Demo2();
            miDemo.Show();
        }

      

     

       
       
    }
}
