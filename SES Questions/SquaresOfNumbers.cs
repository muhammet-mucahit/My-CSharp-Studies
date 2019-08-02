using System;

namespace SquaresOfNumbers
{
    /// <summary>
    ///  Girilen sayıya kadar olan sayıların karelerini hesaplayan kod.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Dongu bu sayiya atanan degere kadar donecek.
            int number;

            // Dongunun nereye kadar donecegini aliyoruz.
            Console.Write("Please enter the number that should be bigger than 1: ");
            number = int.Parse(Console.ReadLine());

            // 1'den girilen sayiya kadar olan sayilarin karelerini yazdiriyoruz.
            for (int i = 1; i <= number; i++)
            {
                Console.Write(Math.Pow(i, 2) + " ");
            }

            // Press any key continue... yazisinin altta gozukmesi icin koda ekliyorum.
            Console.WriteLine();
        }
    }
}
