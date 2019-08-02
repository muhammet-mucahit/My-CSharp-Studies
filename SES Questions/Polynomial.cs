using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Please enter the a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Please enter the b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Please enter the c: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: {0}", a * a + b * b + c * 3);
        }
    }
}
