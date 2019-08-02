using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Yamuk:Sekil
    {
        public int taban;
        public int tavan;
        public int yukseklik;
        public Yamuk(int tab, int tav, int yuk)
        {
            taban = tab;
            tavan = tav;
            yukseklik = yuk;
        }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("-----Yamuk.Yazdir()-----");
            Console.WriteLine(yukseklik);
            Console.WriteLine(taban);
            Console.WriteLine(tavan);
        }
    }
}
