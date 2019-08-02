using System;

namespace OvertimePay
{
    class Program
    {
        static void Main(string[] args)
        {
            int extra;

            // Calisanin kac saat mesaiye kaldigini aliyoruz.
            Console.Write("How many hours did you work last month as extra: ");
            extra = int.Parse(Console.ReadLine());

            // Soruda verilen kosullara gore extra maasin miktari yukarida extranin icerisine 
            // hesaplaniyor.
            if (extra <= 10)
                extra *= 1;
            else if (extra > 10 && extra <= 20)
                extra *= 2;
            else if (extra > 20 && extra <= 40)
                extra *= 3;
            else if (extra > 40 && extra <= 100)
                extra *= 4;
            else
                extra *= 5;

            // Alinan mesayi ucreti ekrana basiliyor.
            Console.WriteLine(extra);
        }
    }
}
