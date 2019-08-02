using System;

namespace PrimeNumbers
{
    /// <summary>
    ///  İlk 20 asal sayıyı veren kod.
    /// </summary>

    class Program
    {
        // Verilen sayinin asal olup olmadigini soyleyen fonksiyon.
        static bool prime(int num)
        {
            int counter = 0; // Eger counter degiskeni 0 olarak kalirsa bu sayi asaldir. Cunku sayi her tam bolundugunde counter bir artacak.

            for(int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    counter++;
            }

            if (counter == 0)
                return true;
            
            return false;
        }

        static void Main(string[] args)
        {
            int counter = 0; // Her asal sayi buldugumuzda counter 1 artacak. Ilk 20 olanini bulmak istedigimiz icin kullaniyorum.

            // 100.000 degeri rastgele ilk 20 asal sayimizin bulunabilecegini dusundugum 0-100.000 araligindan dolayi benim kullandigim random bir sayidir.
            for (int i = 2; i <= 100000 ; i++)
            {
                if(prime(i))
                {
                    Console.Write(i + " ");
                    counter++;
                }

                if (counter == 20)
                    break;
            }
        }
    }
}
