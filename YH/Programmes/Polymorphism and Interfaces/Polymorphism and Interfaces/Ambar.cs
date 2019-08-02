using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Interfaces
{
    class Ambar
    {
        // FIFO

        private Queue<IUrun> envanter { get; set; }

        public Ambar()
        {
            envanter = new Queue<IUrun>();
        }

        public IUrun EskiDegeriOku()
        {
            IUrun eskiDeger = envanter.First();
            return eskiDeger;
        }

        public IUrun YeniDegeriOku()
        {
            IUrun yeniDeger = envanter.Last();
            return yeniDeger;
        }

        public void Ekle(IUrun eklenecekUrun)
        {
            envanter.Enqueue(eklenecekUrun);
        }
    }
}
