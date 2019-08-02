using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Interfaces
{
    public static class Yazdir
    {
        public static void ConsolaDegerYaz(IYazdir yazdirilabilirDeger)
        {
            yazdirilabilirDeger.Yazdir();
        }
    }
}
