using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTriangleWithStars
{
    class Program
    {
        static void DrawReverseTriangle(int num)
        {
            char[,] star = new char[num,num];
            int k;
            
            // i ve j sabit fakat k matrisin tam tersinden baslayip yine j, i olunca adedinde *'i matrisin tam ters tarafina atar.
            for (int i = 0; i < num; i++)
            {
                k = num - 1;
                for (int j = 0; j <= i; j++)
                {
                    star[i, k] = '*';
                    k--;
                }         
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(star[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());

            DrawReverseTriangle(number);
        }
    }
}
