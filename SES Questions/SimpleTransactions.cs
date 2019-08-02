using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            Console.Write("Please enter the first number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: {0} + {1} = {2}", first, second, first + second);
            Console.WriteLine("Mines: {0} - {1} = {2}", first, second, first - second);
            Console.WriteLine("Multiple: {0} * {1} = {2}", first, second, first * second);
            Console.WriteLine("Divide: {0} / {1} = {2}", first, second, first / second);
            Console.WriteLine("Over: {0} % {1} = {2}", first, second, first % second);
        }
    }
}
