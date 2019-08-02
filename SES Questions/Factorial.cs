using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static int Factorial(int num)
        {
            int sum = 1;
            
            for(int i = num; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
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
