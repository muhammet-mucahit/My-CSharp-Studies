using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Yonelimli_CSharp_1
{
    class Program
    {
        //static void degistir(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        static void Main(string[] args)
        {
            Kare kare = new Kare();

            int deneme = kare.Boyut;

            kare.Boyut = 0;

            Yardimci.UyariYaz("Boyut.... = " + kare.Boyut);

            //Kare kare = new Kare(10);

            //Console.WriteLine("Kare adedi... = {0}",kare.AdetGetir());

            //Kare kare2 = new Kare(20);

            //Kare kare3 = new Kare(30);

            //Console.WriteLine("Kare adedi... = {0}", kare.AdetGetir());

            //Kare kare4 = new Kare(11);

            //Kare kare5 = new Kare(22);

            //Kare kare6 = new Kare(33);

            //Kare kare7 = new Kare(44);

            //Console.WriteLine("Kare adedi... = {0}", kare2.AdetGetir());

            //Yardimci.UyariYaz("Uyari mesaji yazildi");

            //Yardimci.UyariYaz("Yeni Uyari mesaji yazildi", ConsoleColor.Yellow);

            //int a = 10;
            //int b = 20;

            //degistir(ref a, ref b); // ref icin ilk deger atamasi gereklidir out kullanirsak boyle birsey gerekli degildir.

            //Console.WriteLine("{0} - {1}", a, b);


        }
    }
}
