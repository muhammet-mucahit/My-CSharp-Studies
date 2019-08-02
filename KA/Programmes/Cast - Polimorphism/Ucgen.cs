using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast___Polimorphism
{
    class Ucgen:Sekil
    {
        public int yukseklik;
        public int taban;
        public int AlanGetir()
        {
            return yukseklik * taban / 2;
        }
    }
}
