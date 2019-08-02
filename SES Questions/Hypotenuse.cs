using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            Console.Write("First side: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Second side: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Hypotenuse: {0}", Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2)));
        }
    }
}
