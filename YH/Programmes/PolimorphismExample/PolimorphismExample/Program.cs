using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Otomobil[] o = new Otomobil[3];

        //    Otomobil o1 = new Otomobil();

        //    o1.UreticiFirma = "BMW";
        //    o1.Model = "M145";
        //    o1.Renk = "Gri";
        //    o1.KM = 15000;
        //    o1.Yil = 2017;

        //    Otomobil o2 = new Otomobil();

        //    o2.UreticiFirma = "MERCEDES";
        //    o2.Model = "R200";
        //    o2.Renk = "Siyah";
        //    o2.KM = 20000;
        //    o2.Yil = 2016;

        //    Otomobil o3 = new Otomobil();

        //    o3.UreticiFirma = "AUDI";
        //    o3.Model = "Sem455";
        //    o3.Renk = "Sari";
        //    o3.KM = 8500;
        //    o3.Yil = 2015;

        //    o[0] = o1;
        //    o[1] = o2;
        //    o[2] = o3;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        o[i].Yazdir();
        //    }

            ArrayList otomobilDizi = new ArrayList(); // dinamik bellek gibi sinir belirtmiyorsun ama dizi tanimliyorsun.
            Otomobil o1 = new Otomobil();
            Otomobil o2 = new Otomobil();
            Otomobil o3 = new Otomobil();


            o1.UreticiFirma = "BMW";
            o1.Model = "M145";
            o1.Renk = "Gri";
            o1.KM = 15000;
            o1.Yil = 2017;

            o2.UreticiFirma = "MERCEDES";
            o2.Model = "R200";
            o2.Renk = "Siyah";
            o2.KM = 20000;
            o2.Yil = 2016;

            o3.UreticiFirma = "AUDI";
            o3.Model = "Sem455";
            o3.Renk = "Sari";
            o3.KM = 8500;
            o3.Yil = 2015;

            otomobilDizi.Add(o1);
            otomobilDizi.Add(o2);
            otomobilDizi.Add(o3);

            foreach (Otomobil araba in otomobilDizi)
            {
                araba.Yazdir();
            }

            Console.WriteLine();
            Otomobil seciliDeger = (Otomobil)otomobilDizi[1];
            seciliDeger.Yazdir();

            Otomobil o4 = new Otomobil();

            o4.UreticiFirma = "FERRARI";
            o4.Model = "1565";
            o4.Renk = "Mavi";
            o4.KM = 4968;
            o4.Yil = 1900;

            Console.WriteLine();

            otomobilDizi.Add(o4);

            Otomobil yeniDeger = (Otomobil)otomobilDizi[3];
            yeniDeger.Yazdir();

            Console.WriteLine();

            Otomobil o5 = new Otomobil();

            o5.UreticiFirma = "BUGATTI";
            o5.Model = "6+26";
            o5.Renk = "Kirmizi";
            o5.KM = 26546;
            o5.Yil = 2004;

            otomobilDizi.Insert(2, o5);

            yeniDeger = (Otomobil)otomobilDizi[2];
            yeniDeger.Yazdir();

            Console.WriteLine();

            Otomobil otoSil = (Otomobil)otomobilDizi[1];
            otomobilDizi.Remove(otoSil);
            Otomobil otoSil2 = (Otomobil)otomobilDizi[1];
            otoSil2.Yazdir();  // sildikten sonra bir ustteki indexi silinenin yerine gelecek sekilde getirir ve sonrasindaki indexler 1 azalir.

            otomobilDizi.RemoveAt(1); // boyle de siliniyor direkt

            Console.WriteLine();
            Console.WriteLine(otomobilDizi.Count); // kac eleman oldugunu soyler

            Console.WriteLine();

            Telefon t1 = new Telefon();

            t1.UreticiFirma = "APPLE";
            t1.Marka = "IPHONE7";
            t1.Fiyat = "3000 TL";

            otomobilDizi.Add(t1);

            foreach (Telefon item in otomobilDizi)  // HATA sadece tek tip olacak arraylistin icinde 
            {
                item.Yazdir();
            }

            Console.WriteLine();

        }
    }
}
