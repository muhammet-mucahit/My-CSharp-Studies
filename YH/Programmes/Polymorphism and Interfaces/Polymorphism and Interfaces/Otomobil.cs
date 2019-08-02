using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Interfaces
{
    class Otomobil : IYazdir, IUrun // interface abstract class gibi biraz // override a gerek duymaz ama
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
        public int Yil { get; set; }
        public string Renk { get; set; }

        public void Yazdir()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4} \n",UreticiFirma,Model,Yil,Renk,KM);
        }

        public void DepolananDegeriOku()
        {
            Console.WriteLine("{0} Firmasinin Urettigi {1} Modeldeki Arac Ambarin B Bolumunde Bulunmaktadir... \n",UreticiFirma,Model);
        }
    }
}
