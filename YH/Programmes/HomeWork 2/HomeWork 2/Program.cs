using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("Secret Text.txt");
            StreamWriter output = new StreamWriter("Normal Text.txt");
            string line = "";

            while (line != null)
            {
                line = input.ReadLine();

                if (line != null)
                {
                    char[] characters = line.ToCharArray();

                    Array.Reverse(characters);

                    //Console.WriteLine(characters);

                    output.WriteLine(characters);
                }
                
            }

            output.Close();
            input.Close();

        }
    }
}
