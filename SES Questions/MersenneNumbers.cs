using System;

namespace MersenneNumbers
{
    /// <summary>
    ///  İlk 20 Mersenne sayısını veren kod. (2^n - 1 formulunden cikan sayi dizileridir)
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20 ; i++)
            {
                Console.WriteLine(Math.Pow(2, i) - 1);
            }
        }
    }
}
