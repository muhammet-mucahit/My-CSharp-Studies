using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensiolLoop
{
    class Program
    {
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] array = new int [6,4];
            int j = 0, i;

            for(i = 1; i < 100; i++)
            {
                if (i % 15 == 0)
                {
                    array[j,0] = i;
                    j++;
                } 
            }

            j = 0;

            for (i = 1; i <= 30; i++)
            {
                if(i % 5 == 0)
                {
                    array[j,1] = i;
                    j++;
                }
            }

            j = 0;

            for (i = 100; i >= 50; i--)
            {
                if (i % 10 == 0)
                {
                    array[j, 2] = i;
                    j++;
                }
            }

            j = 0;
            i = 2;

            while (i <= 64)
            {
                array[j, 3] = i;
                j++;
                i *= 2;
            }

            PrintArray(array);
        }
    }
}
