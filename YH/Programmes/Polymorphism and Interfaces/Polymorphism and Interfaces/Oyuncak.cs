using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Interfaces
{
    class Oyuncak : IYazdir, IUrun
    {
        public string Imalatci { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }

        public void Yazdir()
        {
            Console.WriteLine("{0} ... {1} ... {2} \n",Imalatci,Adi,Fiyat);
        }

        public void DepolananDegeriOku()
        {
            Console.WriteLine("{0} oyuncagi C bolumunde bolumunde bulunmaktadir \n",Adi);
        }
    }
}
