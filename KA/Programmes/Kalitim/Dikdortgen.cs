using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Dikdortgen:Sekil
    {
        private int yukseklik;
        private int genislik;

        public int Genislik
        {
            get
            {
                return genislik;
            }
            set
            {
                genislik = value;
            }
        }

        public int Yukseklik
        {
            get
            {
                return yukseklik;
            }
            set
            {
                yukseklik = value;
            }
        }

        public Dikdortgen()
        {
            Console.WriteLine("Dikdortgen() Cagrildi.");
        }
    }
}
