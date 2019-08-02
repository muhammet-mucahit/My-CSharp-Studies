using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Telefon:Urun
    {
        public string Uretici { get; set; }
        public string Model { get; set; }
        public string Fiyat { get; set; }
        public bool GoruntuluKonusma { get; set; }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("{0} - {1} - {2} - {3} \n", Uretici, Model, Fiyat,GoruntuluKonusma);
        }
    }
}
