using System;

namespace DaysBetween2Date
{
    /// <summary>
    ///  İki tarih arasındaki gün sayısını bulan program.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            DateTime first = new DateTime(1996, 07, 20);
            DateTime second = new DateTime(2017, 07, 13);

            TimeSpan difference = second - first;

            Console.WriteLine(difference.TotalDays); 
        }
    }     
}   
