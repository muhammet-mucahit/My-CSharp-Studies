using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Urun
    {
        public int UrunNo { get; set; }

        public virtual void Yazdir()
        {
            Console.Write("Urun No : {0}, ",UrunNo);
        }
    }
}
