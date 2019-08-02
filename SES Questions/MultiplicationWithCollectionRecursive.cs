using System;

namespace MultiplicationWithCollectionRecursive
{
    /// <summary>
    ///  Recursive olarak toplama işlemi kullanarak çarpma işlemi yapan kod.
    /// </summary>

    class Program
    {
        // Verilen 2 sayiyi recursive olarak carpan fonksiyon.
        static int multiple(int a, int b)
        {
            if (b < 1)
                return 0;                       // eger deger 1 den kucuk olursa yani aslinda 0 oldugunda 0 dondurecek cunku 0 x sayi = 0'dir.
            return a + multiple(a, b - 1);      // 3 x 4 islemi mesela 3 + (3 x 3) olacak sonra o fonksiyon gelecek (3 x 2) yi cagiracak vs...
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
