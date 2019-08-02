using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismExample
{
    class Otomobil
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int KM { get; set; }
        public string Renk { get; set; }

        public void Yazdir()
        {
            Console.WriteLine("{0} yilinda {1} firmasinin urettigi {2} modelde {3} renginde bir aractir.(KM --> {4})",Yil,UreticiFirma,Model,Renk,KM);
        }
    }
}
