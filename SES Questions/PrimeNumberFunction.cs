using System;

namespace PrimeNumberFunction
{
    /// <summary>
    ///  Verilen sıradaki asal sayıyı döndüren kod.
    ///  2,3,5,7,11,13,17,19… f(4) için 7 --> Yani 4. asal sayi diye direkt istendiginde ekrana basabilmeli.
    /// </summary>

    class Program
    {
        // Verilen sayinin asal olup olmadigini soyleyen fonksiyon.
        static bool prime(int num)
        {
            int counter = 0;  // Eger counter degiskeni 0 olarak kalirsa bu sayi asaldir. Cunku sayi her tam bolundugunde counter bir artacak.

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    counter++;
            }

            if (counter == 0)
                return true;
            
            return false;
        }

        // Ornegin f(4) yani 4. asal sayi degerini verecek fonksiyon.
        static int f(int num)
        {
            int counter = 0;

            // 9999 sayisi tamamen random olarak verilmistir.
            // Counter her asal sayi ciktiginda 1 artacak ve istenilen sayiya geldiginde return ile fonksiyonu bitirip sonucu donderecek.
            for(int i = 2; i < 9999; i++)
            {
                if (prime(i))
                {
                    counter++;
                }
                if(counter == num)
                {
                    return i;
                }
                //prime_numbers.Add(i);
            }

            return 0;

        }

        static void Main(string[] args)
        {
            int num;     // Kacinci asal sayi isteniyorsa kullanici bu sayiyi girecek ve bu deger bu variable'a setlenecek.

            Console.Write("Please enter a number:  ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("f({0}) = {1}", num, f(num));
        }
    }
}
