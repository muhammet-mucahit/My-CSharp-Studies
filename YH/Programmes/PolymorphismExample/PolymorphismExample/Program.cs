using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Urun> envanter = new List<Urun>();

            Otomobil oto1 = new Otomobil();

            oto1.UreticiFirma = "BMW";
            oto1.Model = "X6";
            oto1.Renk = "Siyah";
            oto1.UrunNo = 147;

            Telefon tel1 = new Telefon();

            tel1.Uretici = "NOKIA";
            tel1.Model = "5110";
            tel1.Fiyat = "10";
            tel1.GoruntuluKonusma = false;
            tel1.UrunNo = 258;

            envanter.Add(tel1);
            envanter.Add(oto1);

            Giyim giy1 = new Giyim();

            giy1.Firma = "PUMA";
            giy1.UrunTipi = "Yazlik";
            giy1.Fiyat = 50;
            giy1.UrunNo = 8002;

            envanter.Add(giy1);

            foreach (Urun item in envanter) // fonksiyonlar ayni isimde olmazsa override etmeye izin vermez zaten gerek de duyulmaz oyle olursa.
            {
                item.Yazdir();
            }


        }
    }
}
