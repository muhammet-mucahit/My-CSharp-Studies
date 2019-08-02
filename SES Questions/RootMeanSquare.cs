using System;
using System.Collections.Generic;

namespace RootMeanSquare
{
    /// <summary>
    ///  Alinan bir dizinin RMS (Root Mean Square) bulan program. 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();      // Okunan sayilar integer hale donusturuldukten sonra bu dizide saklanacak.
            List<int> temp = new List<int>();       // Diger dizideki sayilar degistirilmek istendiginde bu gecici dizi kullanilacak.
            string numbers;                         // Okunan sayilari tutar.
            string number = "";                     // Number eger diziye negatif tam sayi veya bir basamaktan fazla bir sayi girilirse yani mesela
                                                    // 90 girildi 90 i bir sayi olarak almak icin numbers stringinden number'a bu sayi okunup daha sonra
                                                    // integer veri tipine donusturulecek.

            // Diziye atacak sayilari kullanicidan alir fakat birden fazla sayi girilecekse aralarinda bosluk birakilarak girilmelidir.
            Console.Write("Please enter the numbers: ");
            numbers = Console.ReadLine();

            numbers += ' ';                         // Okunan dizinin sonuna bir bosluk ekliyorum cunku asagida dongude if kontrolu yapilirken lazim olacak.

            // Okunan sayilar integer hale donusturulup diziye ekleniyor.
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] != ' ')
                {
                    number += numbers[i];
                }

                else
                {
                    array.Add(int.Parse(number));
                    number = "";
                }
            }

            // Dizideki sayilar yazdiriliyor.
            Console.Write("Numbers: ");

            foreach (var item in array)
                Console.Write(item + " ");

            Console.WriteLine();

            // Sayilarin kareleri yazdiriliyor.
            Console.Write("Squares: ");

            foreach (var item in array)
            {
                temp.Add(item * item);
                Console.Write(item * item + " ");
            }

            Console.WriteLine();

            // Sayilarin ortalamasi yazdiriliyor.
            int sum = 0;
            Console.Write("Mean   : ");

            foreach (var item in temp) sum += item;

            Console.WriteLine("{0} / {1} = {2:f2}", sum, temp.Count, (float)sum / temp.Count);

            // Sayilarin ortalamasinin koku yazdiriliyor.
            Console.Write("Square : ");

            Console.WriteLine("{0:f2}", Math.Sqrt((float)sum / (float)temp.Count));
        }
    }
}
