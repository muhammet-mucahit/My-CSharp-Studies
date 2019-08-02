using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Urun> envanter = new List<Urun>();

            Telefon tel1 = new Telefon();

            tel1.Uretici = "NOKIA";
            tel1.Model = "3310";
            tel1.UrunNo = 123;

            envanter.Add(tel1);

            Otomobil oto1 = new Otomobil();

            oto1.Uretici = "TOYOTA";
            oto1.Model = "Corolla";
            oto1.Fiyat = 15750;
            oto1.UrunNo = 151;

            envanter.Add(oto1);

            Console.WriteLine("--- ENVANTERDEKI ARACLAR --- \n");
            foreach (Urun item in envanter)
            {
                item.Yazdir();
            }


            Console.WriteLine();
        }
    }
}
