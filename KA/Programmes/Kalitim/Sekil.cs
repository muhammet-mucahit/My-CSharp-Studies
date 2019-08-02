using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Sekil
    {
        private int alan;
        private int x;
        private int y;
        private int cevre;

        public int Cevre
        {
            get
            {
                return cevre;
            }

            set
            {
                cevre = value;
            }
        }

        public int Alan
        {
            get
            {
                return alan;
            }

            set
            {
                alan = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public void AlaniYaz()
        {
            Console.WriteLine("Koordinatlari " + x + "," + y + " olan seklin alani = " + alan);
        }

        public Sekil()
        {
            Console.WriteLine("Sekil() Cagrildi.");
        }

        public Sekil(int x, int y)
        {
            Console.WriteLine("Sekil(" + x + ',' + y + ") Cagrildi.");
        }
    }
}
