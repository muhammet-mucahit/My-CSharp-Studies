using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneye_Dayali_Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            Ogrenci ogr2 = new Ogrenci();

            ogr1.old = 21;
            ogr1.name = "Mucahit";

            ogr2.old = 25;
            ogr2.name = "Ahmet";

            ogr1.yazdir();
            ogr2.yazdir();
        }
    }
}
