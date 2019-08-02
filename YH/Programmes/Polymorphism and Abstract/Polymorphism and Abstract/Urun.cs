using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Abstract
{
    abstract class Urun
    {
        public int UrunNo { get; set; }

        public void IslemYap()
        {
            Console.WriteLine(UrunNo);
        }

        public abstract void Yazdir(); // Govde yazilmaz, yazilamaz. // normal classin icinde abstract methot tanimlanamaz.


        
    }
}
