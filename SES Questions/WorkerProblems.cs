using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, worker;

            Console.Write("How many days does a worker finish a work: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("How many workers will work in total: ");
            worker = int.Parse(Console.ReadLine());

            Console.WriteLine("The end of the work is {0} days.", day/worker);
        }
    }
}
