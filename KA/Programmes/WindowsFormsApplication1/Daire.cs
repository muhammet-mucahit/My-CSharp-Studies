using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Daire:Sekil
    {
        private int cap;

        public override void bitisAta(int bx, int by)
        {
            cap = bx - X;
        }

        public override void Ciz(System.Drawing.Graphics cizimAraci)
        {
            cizimAraci.DrawEllipse(Pens.DeepSkyBlue, X, Y, cap, cap);
        }
    }
}
