using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<IYazdir> envanter = new List<IYazdir>();

            Otomobil o1 = new Otomobil();

            o1.UreticiFirma = "BMW";
            o1.Model = "X5";
            o1.KM = 85000;
            o1.Renk = "Siyah";
            o1.Yil = 2005;

            //envanter.Add(o1);

            Telefon t1 = new Telefon();

            t1.Firma = "NOKIA";
            t1.Model = "5110";
            t1.Fiyat = 1.500;

            //envanter.Add(t1);

            //foreach (var item in envanter) // var ne oldugunu anliyor arayacagi seyin icinde ;) // var yerine IYazdir yazsan da olurdu ayni.
            //{
            //    item.Yazdir();
            //}

            Console.WriteLine("--- 1. Islem ---");
            Yazdir.ConsolaDegerYaz(o1);
            Yazdir.ConsolaDegerYaz(t1);
            Console.WriteLine("--- 1. Islem Tamam ---\n");

            Ambar benimAmbar = new Ambar();
            benimAmbar.Ekle(t1);
            benimAmbar.Ekle(o1);

            var benimEskiUrun = benimAmbar.EskiDegeriOku(); // var a ne verirsen o tipe donusuyor burda interface oluyor mesela
            benimEskiUrun.DepolananDegeriOku();


            Console.WriteLine("--- 3. islem --- \n");

            Oyuncak benimOyuncak = new Oyuncak() { Imalatci = "ABC AS.", Adi = "Konusan araba", Fiyat = 250 };
            benimAmbar.Ekle(benimOyuncak);

            benimEskiUrun = benimAmbar.YeniDegeriOku();
            benimEskiUrun.DepolananDegeriOku();
            
        }
    }
}
