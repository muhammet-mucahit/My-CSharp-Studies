using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nice_Example___Shape__
{
    class Lcharacter
    {
        public int X, Y;
        private int width;
        private int heigth;

        public Lcharacter()
        {
            X = 5;
            Y = 10;
            width = 10;
            heigth = 5;
        }

        public void show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < heigth; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.Write(" ");
            }

            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(X + i, Y + heigth);
                Console.Write(" ");
            }


            Console.ResetColor();
        }
    }
}
