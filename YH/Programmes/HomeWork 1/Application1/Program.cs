using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ODEV 1

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            string realID = "mucahit aktepe";
            string inputID;

            Console.WriteLine("Please, Enter your Personal ID and click enter");
            inputID = Console.ReadLine();

            if (realID == inputID)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You enter in succesfully");
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect Entering !!! Please try again !!!");
            }

            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}
