using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinNumberBetweenThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];

            Console.Write("Enter the first number: ");
            number[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            number[1] = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number[2] = int.Parse(Console.ReadLine());

            int min = 0;
            int max = 999999;

            for (int i = 0; i < 3; i++)
            {
                if(number[i] > min)
                {
                    min = number[i];
                }

                if(number[i] < max)
                {
                    max = number[i];
                }
            }

            Console.WriteLine("Maximum number {0}, Minimum number {1}", min, max);
        }
    }
}
