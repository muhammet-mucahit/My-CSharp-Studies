using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare();

            kare.X = 10;
            kare.Y = 20;
            kare.Alan = 100;
            //kare.AlaniYaz();

            Dikdortgen dikdortgen = new Dikdortgen();

            dikdortgen.X = 30;
            dikdortgen.Y = 40;
            dikdortgen.Alan = 300;
            //dikdortgen.AlaniYaz();
        }
    }
}
