using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Abstract
{
    class Telefon:Urun
    {
        public string Uretici { get; set; }
        public string Model { get; set; }

        public override void Yazdir()
        {
            Console.WriteLine("{0} - {1}",Uretici,Model);
        }
    }
}
