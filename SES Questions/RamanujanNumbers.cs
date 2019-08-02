using System;
using System.Collections.Generic;

namespace RamanujanNumbers
{
    /// <summary>
    ///  Verilen 4 sayinin Ramanujan sayisi olup olmadigini inceleyen programdir.
    /// </summary>

    class Program
    {
        // Girilen sayilarin Ramanujan sayilari olup olmadigini arastiran fonksiyon. 
        static bool ramanujan(int[] numbers)
        {
            // Normal dizimizde bulunan sayilarin kupleri daha kolay islem icin gecici diziye atiliyor.
            int[] temp = new int[4];
            
            for (int i = 0; i < 4; i++)
			{
                temp[i] = (int)Math.Pow(numbers[i], 3); 
			}

            // Tum sayilarin birbirleriyle kup toplamlari karsilastirilip esitlik bulunursa true bulunmazsa false donduruyoruz.
            if (temp[0] + temp[1] == temp[2] + temp[3])
                return true;
            if (temp[0] + temp[2] == temp[1] + temp[3])
                return true;
            if (temp[0] + temp[3] == temp[1] + temp[2])
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Please enter {0}. number: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(ramanujan(numbers));
        }
    }
}
