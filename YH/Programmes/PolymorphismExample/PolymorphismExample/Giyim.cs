using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Giyim:Urun
    {
        public string UrunTipi { get; set; }
        public string Firma { get; set; }
        public int Fiyat { get; set; }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("{0} - {1} - {2} \n",UrunTipi, Firma, Fiyat);
        }
    }
}
