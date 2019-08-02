using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int num)
        {
            if (num < 2)
                return num;
            else
                return Fibonacci(num - 1) + Fibonacci(num - 2);      
        }

        static void Sequence(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            Sequence(number);
        }
    }
}
