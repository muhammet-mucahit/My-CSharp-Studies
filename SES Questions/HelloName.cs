using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }
    }
}
