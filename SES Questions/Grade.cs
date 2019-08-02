using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;

            Console.WriteLine("To exit please enter -1");

            while(grade != -1)
            {
                Console.Write("Please enter the point: ");
                grade = int.Parse(Console.ReadLine());

                if (grade <= 100 && grade >= 0)
                {
                    if (grade >= 90 && grade <= 100)
                        Console.WriteLine('A');
                    else if (grade >= 80 && grade <= 89)
                        Console.WriteLine('B');
                    else if (grade >= 70 && grade <= 79)
                        Console.WriteLine('C');
                    else if (grade >= 60 && grade <= 69)
                        Console.WriteLine('D');
                    else if (grade >= 50 && grade <= 59)
                        Console.WriteLine('E');
                    else
                        Console.WriteLine('F');
                }   
                else
                    Console.WriteLine("The point is invalid, please enter a valid point ! ! !"); 
            }
        }
    }
}
