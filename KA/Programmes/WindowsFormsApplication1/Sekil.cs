using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Sekil
    {
        private int x;
        private int y;

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

        public virtual bool Icindemi(int px, int py);

        public virtual void bitisAta(int bx, int by)
        {

        }

        public virtual void Ciz(Graphics cizimAraci)
        {
            
        }
    }
}
