using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Calisan
    {
        string elemanAdi;
        string elemanUnvan;
        DateTime isGirisZamani;
        Firma sirket;

        public string ElemanAdi { get; set; }
        public string ElemanUnvan { get; set; }
        public DateTime IsGirisZamani { get; set; }
        public Firma Sirket { get; set; }

        public void SirketBilgisiGoster();
    }
}
