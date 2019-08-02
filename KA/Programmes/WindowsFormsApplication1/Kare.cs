using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Kare:Sekil
    {
        //public int x;
        //public int y;
        public int width;
        //public int height;

        public Kare()
        {
            //x = y = 0;
            width = 0;//height = 0;
        }

        public override void bitisAta(int bx, int by)
        {
            width = bx - X;
        }

        public override void Ciz(Graphics cizimAraci)
        {
            cizimAraci.DrawRectangle(Pens.Tomato, X, Y, width, width);
        }
    }
}
