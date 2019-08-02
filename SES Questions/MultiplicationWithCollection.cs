using System;

namespace MultiplicationWithCollection
{
    /// <summary>
    ///  Toplama işlemi kullanarak çarpma işlemi yapan kod.
    /// </summary>

    class Program
    {
        // Verilen 2 sayiyi toplama islemi ile carpan fonksiyon.
        static int multiple(int a, int b)
        {
            int result = 0;

            // Mesele 3 x 4 isleminde ikinci sayi kadar 3 toplaniyor yani 3 + 3 + 3 + 3 yapiliyor ve carpma islemi sonucu bulunuyor.
            for (int i = 0; i < b; i++)
            {
                result += a;    
            }

            return result;
        }

        static void Main(string[] args)
        {
            int first, second;     

            Console.Write("Please enter first number : ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} x {1} = {2}", first, second, multiple(first, second));
        }
    }
}
