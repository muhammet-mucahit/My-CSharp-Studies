using System;

namespace PrimeMersenneNumbers
{
    /// <summary>
    ///  Asal Mersenne sayılarini veren kod. (Mersenne sayilari 2^n - 1 formulunden cikan sayi dizileridir)
    /// </summary>

    class Program
    {
        // Verilen sayinin asal olup olmadigini soyleyen fonksiyon.
        // Buyuk sayi gelme olasiligina karsi parametreyi long tutuyorum.
        static bool prime(long num)
        {
            int counter = 0; // Eger counter degiskeni 0 olarak kalirsa bu sayi asaldir. Cunku sayi her tam bolundugunde counter bir artacak.

            for (int i = 2; i <= num / 2; i++)
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
            long num;

            // Asagidaki 20 sayisi bir cok asal mersenne sayisi bulmak icin verilmis random bir sayidir.
            // Ayrica 2^20 zaten cok buyuk bir sayi olacaktir...
            for (long i = 1; i <= 20; i++)
            {
                num = (long)Math.Pow(2, i) - 1;
                
                if(prime(num))
                    Console.WriteLine(num);
            }
        }
    }
}
