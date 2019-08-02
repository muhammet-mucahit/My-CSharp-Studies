using System;
using System.Text;
using System.IO;

// string message = (x>y) ? "50 TL" : "10 TL";

namespace Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //int b;
            //b = int.Parse(a);

            //switch (b)
            //{
            //    case 0:
            //    case 1:
            //        Console.WriteLine("Kazandiniz"); break;
            //}

            //StreamReader input = new StreamReader("text.txt");
            //string line = "";

            //while (line != null)
            //{
            //    line = input.ReadLine();

            //    if (line != null)
            //        Console.WriteLine(line);
            //}

            //input.Close();

            //int[] numbers = new int[5];
            //int[] numbers = { 12, 15, 16, 17 };

            //numbers.length = herhangi bir dizinin uzunlugunu yani kac elemanli oldugunu soyluyor.

            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            string text = "Ya oldugun gibi gorun ya gorundugun gibi ol";

            char[] characters = text.ToCharArray();

            //foreach (char ch in characters)
            //{
            //    Console.WriteLine(ch);
            //}

            //Console.WriteLine(characters);

            Array.Reverse(characters);

            Console.WriteLine(characters);
        }
    }
}
