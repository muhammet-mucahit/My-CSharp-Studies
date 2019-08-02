using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Yonelimli_CSharp_1
{
    class Kare
    {
        private int boyut;
        private int numara;

        public int Boyut
        {
            get
            {
                Yardimci.UyariYaz("Boyut--->Get Cagrildi");
                return boyut;
            }

            set
            {
                Yardimci.UyariYaz("Boyut--->Set Cagrildi , value "+value);
                if (value <= 0)
                {
                    Yardimci.UyariYaz("Boyut 0 a esit veya kucuk olamaz");
                    boyut = 10;
                }
                else
                {
                    boyut = value;
                }
            }
        }
        //private static int adet;

        //public Kare(int b)
        //{
        //    Random rnd = new Random();
        //    boyut = rnd.Next(0, 20);

        //    Console.WriteLine(boyut + " olan Kare() Cagrildi");

        //    numara = adet;
        //    adet++;
        //}

        //public int AdetGetir() { return adet; }
    }
}
