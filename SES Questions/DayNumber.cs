using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_day, first_month, first_year;
            int second_day, second_month, second_year;

            Console.Write("Please enter the first date: ");
            first_day = int.Parse(Console.ReadLine());
            first_month = int.Parse(Console.ReadLine());
            first_year = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second date: ");
            second_day = int.Parse(Console.ReadLine());
            second_month = int.Parse(Console.ReadLine());
            second_year = int.Parse(Console.ReadLine());
            
            DateTime dt = new DateTime(first_year, first_month, first_day); // It has to be Year.Month.Date format
            DateTime dt2 = new DateTime(second_year, second_month, second_day); // It has to be Year.Month.Date format

            TimeSpan tspan = dt.Subtract(dt2); // The function will compute total days between two parameters
            int totalDay = Convert.ToInt32(tspan.TotalDays);

            Console.WriteLine("There are {0} days between two dates", Math.Abs(totalDay));
        }
    }
}
