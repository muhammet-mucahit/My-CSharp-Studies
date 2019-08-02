using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitMatrix
{
    class Program
    {
        static void CreateUnitMatrix(int num)
        {
            int[,] array = new int[num, num];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                        array[i, j] = 1;
                }
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

            CreateUnitMatrix(number);    
        }
    }
}
