using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Otomobil:Urun
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("{0} - {1} - {2} \n",UreticiFirma,Model,Renk);
        }
    }
}
