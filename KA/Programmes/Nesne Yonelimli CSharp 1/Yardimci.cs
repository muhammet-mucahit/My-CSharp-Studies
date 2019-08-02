using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Yonelimli_CSharp_1
{
    class Yardimci
    {
        public static void UyariYaz(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("{0,-39}", mesaj);
            Console.WriteLine("---------------------------------------");

            Console.ResetColor();
            Console.WriteLine();
        }

        public static void UyariYaz(string mesaj, ConsoleColor arkarenk)
        {
            Console.BackgroundColor = arkarenk;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("{0,-39}", mesaj);
            Console.WriteLine("---------------------------------------");

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
