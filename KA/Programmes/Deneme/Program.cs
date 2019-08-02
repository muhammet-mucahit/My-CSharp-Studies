using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello"); // automatically starting line == we don't need to use endl or \n 

            //string input;
            //input = Console.ReadLine(); // The Readline function return string
            
            //int number;
            //number = int.Parse(Console.ReadLine()); // The Parse function convert string to int 

            //float fnumber;
            //fnumber = float.Parse(Console.ReadLine()); // float.Parse() convert string to float

            //Console.WriteLine(input);
            //Console.WriteLine(number);
            //Console.WriteLine(fnumber);

            //Console.Write(input); // Don't start of line automatically 

            //float numberf = 120.90f; // We should use 'f' with float on the final of the number 

            int sayi;

            sayi = false ? 123 : 456;

            Console.WriteLine("{0}", sayi);
        }
    }
}
