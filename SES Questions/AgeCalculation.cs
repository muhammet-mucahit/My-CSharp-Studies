using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int today, birthdate;

            Console.Write("Please enter the today's date: ");
            today = int.Parse(Console.ReadLine());

            Console.Write("Please enter your birthdate: ");
            birthdate = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Age: {0}", today - birthdate);
        }
    }
}
