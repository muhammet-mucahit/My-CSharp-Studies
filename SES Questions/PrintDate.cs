using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;

            Console.Write("Please enter the day: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Please enter the month: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Please enter the year: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Day.Month.Year: {0}.{1}.{2}", day, month, year);
            Console.WriteLine("Month.Day.Year: {0}.{1}.{2}", month, day, year);
            Console.WriteLine("Year.Month.Day: {0}.{1}.{2}", year, month, day);
        }
    }
}
