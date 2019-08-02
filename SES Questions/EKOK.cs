using System;

namespace EKOK
{
    /// <summary>
    ///  2 sayinin en kucuk ortak katini bulan program
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            // EKOK'lari bulunacak sayilari aliyoruz.
            Console.Write("Please enter the first number: ");
            first = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter the second number: ");
            second = int.Parse(Console.ReadLine());

            // Ilk etapta ekok degiskeni iki sayinin carpimina esitleniyor kolay bir sekilde.
            int ekok = first * second;

            // Daha sonra ekok'un degerinden geri gelinerek iki sayiya da bolunen yani daha kucuk bir ortak kat var mi yok mu aranip gercek ekok bulunuyor.
            for(int i = ekok - 1; i > 0; i--)
            {
                if (i % first == 0 && i % second == 0)
                    ekok = i;
            }

            Console.WriteLine(ekok);
        }
    }
}
