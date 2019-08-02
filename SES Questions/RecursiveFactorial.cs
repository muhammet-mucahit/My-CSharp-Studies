using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static int Factorial(int num)
        {
            return (num <= 1) ? 1 : Factorial(num - 1) * num;
        }

        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));
        }
    }
}
