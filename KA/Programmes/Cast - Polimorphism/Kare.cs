using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast___Polimorphism
{
    class Kare:Sekil
    {
        public int boyut;

        public int AlanHesapla()
        {
            return boyut * boyut;
        }
    }
}
