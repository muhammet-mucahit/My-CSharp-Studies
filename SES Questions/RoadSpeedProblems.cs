using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadSpeedProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance, speed;

            Console.Write("Enter the distance: ");
            distance = int.Parse(Console.ReadLine());

            Console.Write("Enter the speed: ");
            speed = int.Parse(Console.ReadLine());

            double time = Convert.ToDouble(distance) / Convert.ToDouble(speed);

            Console.WriteLine("Time is {0} hours", time);
        }
    }
}
