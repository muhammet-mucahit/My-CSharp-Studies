using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Kare:Sekil
    {
        private int boyut;

        public int Boyut
        {
            get
            {
                return boyut;
            }
            set
            {
                boyut = value;
            }
        }

        public int AlanHesapla()
        {
            return boyut * boyut;
        }

        public Kare():base(10,20)
        {
            Console.WriteLine("Kare() Cagrildi.");
        }
    }
}
