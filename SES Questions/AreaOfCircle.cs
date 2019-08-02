using System;

namespace AreaOfCircle
{
    /// <summary>
    ///  Dairenin alanını hesaplayan kod.
    /// </summary>

    class Program
    {
        // Dairenin alanini hesaplayip donduren fonksiyon
        static double area(int r)
        {
            double pi = 3.14;

            return (pi * r * r);

        }

        static void Main(string[] args)
        {
            // Dairenin yaricapi bu degiskende tutulacak.
            int radius;

            // Dairenin yaricap degerini kullanicidan aliyoruz.
            Console.Write("Please enter the radius of the circle: ");
            radius = int.Parse(Console.ReadLine());

            // Dairenin alanini ekrana basiyoruz.
            Console.WriteLine(area(radius));
        }
    }
}
