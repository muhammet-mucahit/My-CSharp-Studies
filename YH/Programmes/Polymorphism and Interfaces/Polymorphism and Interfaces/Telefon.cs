using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Interfaces
{
    class Telefon : IYazdir, IUrun
    {
        public string Firma { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

        public void Yazdir()
        {
            Console.WriteLine("{0} - {1} - {2} \n", Firma, Model, Fiyat);
        }


        public void DepolananDegeriOku()
        {
            Console.WriteLine("{0} , {1} Adli Telefon Ambarin A Bolumunde Bulunmaktadir... \n",Firma,Model);
        }
    }
}
