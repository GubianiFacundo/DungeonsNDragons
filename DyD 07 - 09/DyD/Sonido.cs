using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
     class Sonido
    {
        static string resFolder = @"C:\Users\usuario\Documents\Visual Studio 2010\Projects\DyD\DyD\Resources";

        static string RunningPath = @"C:\Users\usuario\Desktop\DyD-20170906T103827Z-001\DyD\Resources";
        

        public MciPlayer player = new MciPlayer(RunningPath + @"\got2.mp3", "1");
        public MciPlayer fx_hover = new MciPlayer(RunningPath + @"\Hover.wav", "2");
        public MciPlayer fx_click = new MciPlayer(RunningPath + @"\Click.wav", "3");
        public MciPlayer fx_back = new MciPlayer(RunningPath + @"\Click_back.wav", "4");
        public MciPlayer fx_aliado = new MciPlayer(RunningPath + @"\dragon_aliado.wav", "5");
        public MciPlayer fx_enemigo = new MciPlayer(RunningPath + @"\dragon_enemigo.wav", "6");
        public MciPlayer fx_flecha = new MciPlayer(RunningPath + @"\Flecha.wav", "7");
        public MciPlayer fx_ganador = new MciPlayer(RunningPath + @"\ganador.wav", "8");

        public Sonido()
        { }

    }
}
