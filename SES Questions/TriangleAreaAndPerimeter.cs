using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            Console.Write("Enter first side: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Enter second side: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of Triangle: {0}", (first * second) / 2);
            Console.WriteLine("Perimeter of Triangle: {0}", first + second + Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2)));
        }
    }
}
