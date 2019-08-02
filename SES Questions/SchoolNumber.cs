using System;
using System.Collections.Generic;

namespace SchoolNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string number;

            Console.Write("Please enter your school number: ");
            number = Console.ReadLine();

            foreach (char item in number)
            {
                numbers.Add((int)char.GetNumericValue(item));
            }

            foreach (int item in numbers)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
