using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            Console.Write("Enter the first number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            second = int.Parse(Console.ReadLine());

            if(first == second)
                Console.WriteLine("Numbers are equal");
            else
                Console.WriteLine("Numbers are not equal");

            if (first != second)
                Console.WriteLine("Numbers are different");
            else
                Console.WriteLine("Numbers are not different");

            if (first < second)
                Console.WriteLine("First number is smaller than second number");
            else
                Console.WriteLine("First number is not smaller than second number");

            if (second > first)
                Console.WriteLine("Second number is greater than first number");
            else
                Console.WriteLine("Second number is not greater than first number");

            if (first <= second)
                Console.WriteLine("First number is small-equal than second number");
            else
                Console.WriteLine("First number is not small-equal than second number");

            if (second >= first)
                Console.WriteLine("Second number is great-equal than first number");
            else
                Console.WriteLine("Second number is not great-equal than first number");
        }
    }
}
