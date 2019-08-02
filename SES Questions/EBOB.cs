using System;
using System.Collections.Generic;

namespace EBOB
{
    /// <summary>
    ///  2 sayinin en buyuk ortak boleninin bulan program
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            // EBOB'lari bulunacak sayilari aliyoruz.
            Console.Write("Please enter the first number: ");
            first = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter the second number: ");
            second = int.Parse(Console.ReadLine());

            // Ilk sayinin carpanlariyla ikinci sayinin carpanlarini tutacak diziler tanimlaniyor.
            List<int> farray = new List<int>();
            List<int> sarray = new List<int>();
            
            // Ilk sayiyla ikinci sayinin carpanlari ayri 2 diziye atiliyor.
            for(int i = 1; i <= first; i++)
            {
                if (first % i == 0)
                    farray.Add(i);
            }

            for (int i = 1; i <= second; i++)
            {
                if (second % i == 0)
                    sarray.Add(i);
            }

            // En buyuk ortak boleni aradigimiz icin dizinin son elemani de en buyuk oldugu icin ordan baslamamiz daha iyi olacagi icin
            // ve dizinin son elemanina erismeyi beceremedigim icin dizileri ters cevirip en buyuk elemanlari basa getiriyorum.
            farray.Reverse();
            sarray.Reverse();
            
            int counter = 0; // Counter for dongusunde en buyukten baslanarak karsilastiralacagi icin ilk esitlik bulundugunda donguyu bitirmesi icin.
            int ebob = 0; // Bulunan ebob bu degiskene atanacak.

            // Ilk diziyle ikinci dizi yani iki sayinin carpanlari karsilastirilip en buyuk olan ortak carpan bulunduktan sonra counter sayesinde donguden cikiliyor.
            foreach (var item1 in farray)
            {
                foreach (var item2 in sarray)
                {
                    if (item1 == item2)
                    {
                        ebob = item1;
                        counter = 1;
                    }   
                }
                if (counter == 1)
                    break;
            }

            Console.WriteLine(ebob);
        }
    }
}
