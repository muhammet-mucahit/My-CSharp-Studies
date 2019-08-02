using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Kare:Sekil
    {
        public int boyut;

        public Kare(int _boyut)
        {
            boyut = _boyut;
        }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("-----Kare.Yazdir()-----");
            Console.WriteLine(boyut);
        }
    }
}
