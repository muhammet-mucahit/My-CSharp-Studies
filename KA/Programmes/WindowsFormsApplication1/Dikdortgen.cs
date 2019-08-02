using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Dikdortgen:Sekil
    {
        private int width;
        private int height;

        public override bool Icindemi(int px, int py)
        {
            return base.Icindemi(px, py);
        }

        public override void bitisAta(int bx, int by)
        {
            width = bx - X;
            height = by - Y;
        }

        public override void Ciz(System.Drawing.Graphics cizimAraci)
        {
            cizimAraci.DrawRectangle(Pens.ForestGreen, X, Y, width, height);
        }
    }
}
