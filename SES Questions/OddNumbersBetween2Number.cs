using System;

namespace OddNumbersBetween2Number
{
    /// <summary>
    ///  Bir araliktaki sayilardan tek olanlari ekrana bastiran kod.
    /// </summary>

    class Program
    {
        // Verilen sayinin tek olup olmadigini soyleyen fonksiyon.
        static bool odd(int num)
        {
            if (num % 2 == 1)
                return true;
            return false;
        }

        // Girilen iki sayidan ilkinin ikinciden buyuk olup olmadigini soyleyen fonksiyon.
        static bool big(int a, int b)
        {
            if (a > b)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            // Dongu bu iki sayi arasinda donecek.
            int first, second;

            Console.Write("Please enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            second = int.Parse(Console.ReadLine());

            // Eger ilk sayi ikinci sayidan buyukse for dongusu kucukten buyuge yani ikinciden birinceye dogru donecek aksi takdirde tam tersi olacak.
            if(big(first, second))
            {
                for (int i = second; i <= first; i++)
                {
                    if(odd(i))
                        Console.Write(i + " ");
                }
            }
            else
            {
                for (int i = first; i <= second; i++)
                {
                    if(odd(i))
                        Console.Write(i + " ");
                }
            }

        }
    }
}
