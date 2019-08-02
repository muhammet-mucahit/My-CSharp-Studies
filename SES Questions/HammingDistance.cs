using System;

namespace HammingDistance
{
    /// <summary>
    ///  Kullanicidan alinan 2 binary sayinin hamming uzakligini bulan kod. (Hamming uzakligi iki dizgenin kac bit farki oldugudur)
    ///  2 dizge de esit uzunlukta olmak zorundadir.
    ///  Binary olmak zorunda degildir verilen 2 string'in hamming uzakligini da hesaplayabilir.
    /// </summary>

    class Program
    {
        // Hamming uzakligini hesaplayan fonksiyon.
        static int hamming(string a, string b)
        {
            int difference = 0;     // Iki dizge arasinda kac bit fark var yani hamming uzakligi tutacak degisken.

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    difference++;
            }

            return difference;
        }

        static void Main(string[] args)
        {
            string first, second;   // Binary sayilari hic sayiya falan cevirmeden direkt string olarak alip isleme tabi tutacagim.

            Console.WriteLine("!!! ATTENTION !!!");
            Console.Write("The size of strings must be equal.\n\n\n");

            Console.Write("Please enter the first binary number:  ");
            first = Console.ReadLine();

            Console.Write("Please enter the second binary number: ");
            second = Console.ReadLine();

            Console.WriteLine(hamming(first, second));
        }
    }
}
