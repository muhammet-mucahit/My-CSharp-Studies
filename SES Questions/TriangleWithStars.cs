using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleWithStars
{
    class Program
    {
        static void DrawTriangle(int num)
        {
            string star = "*";

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", star);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());

            DrawTriangle(number);
        }
    }
}
