using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Sekil
    {
        public int x;
        public int y;

        public virtual void Yazdir()
        {
            //Console.WriteLine("-----Sekil.Yazdir()-----");
            Console.WriteLine(x + "," + y);
        }
    }
}
