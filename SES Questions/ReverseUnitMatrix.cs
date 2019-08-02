using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseUnitMatrix
{
    class Program
    {
        static void ReverseUnitMatrix(int num)
        {
            int[,] array = new int[num, num];
            int k = 0;

            for (int i = num - 1; i >= 0; i--)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j == k)
                        array[i, j] = 1;
                }
                k++;
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(array[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());

            ReverseUnitMatrix(number);    
        }
    }
}
