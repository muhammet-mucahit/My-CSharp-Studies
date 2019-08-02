using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nice_Example___Shape__
{
    class Program
    {
        static void Main(string[] args)
        {

            Lcharacter obj = new Lcharacter();


            while (true)
            {
                obj.show();

                ConsoleKeyInfo enter = Console.ReadKey();

                if (enter.Key == ConsoleKey.RightArrow)
                {
                    if (obj.X != 70) 
                        obj.X++;
                }

                if (enter.Key == ConsoleKey.UpArrow)
                {
                    if (obj.Y != 0)
                        obj.Y--;
                }

                if (enter.Key == ConsoleKey.LeftArrow)
                {
                    if (obj.X != 0) 
                        obj.X--;
                }

                if (enter.Key == ConsoleKey.DownArrow)
                {
                    if(obj.Y != 25)
                        obj.Y++;
                }
            }

            Console.SetCursorPosition(10, 20);
            Console.WriteLine("Width  = {0}", Console.WindowWidth);
            Console.SetCursorPosition(10, 21);
            Console.WriteLine("Heigth = {0}", Console.WindowHeight);

            Console.Write("\n\n\n");

            Console.ReadKey();
        }
    }
}
