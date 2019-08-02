using System;
using System.Collections.Generic;

namespace MeanOfOddNumber
{
    /// <summary>
    ///  Dizideki tek sayıların ortalamasını bulan kod.
    /// </summary>

    class Program
    {
        // Girilen sayinin tek olup olmadigini soyleyen fonksiyon.
        static bool odd(int num)
        {
            if (num % 2 == 0)
                return false;
            return true;
        }

        static double mean(List<int> arr)
        {
            int sum = 0;                             // multiple dizideki tek elemanlarin toplamini tutacak.
            int counter = 0;                         // counter her tek sayi ciktiginda 1 artacak ve en son sum counter'a yani teklerin sayisina bolunecek.

            foreach (int item in arr)
            {
                if(odd(item))
                {
                    sum += item;
                    counter++;
                }
                    
            }

            if (counter == 0)
                return 0;

            return ((double)sum / (double)counter); // Dizideki tek sayilarin toplamini size'a bolunmesi bunlarin ortalamasini verir.      
        }

        static void Main(string[] args)
        {
            List<int> array = new List<int>();   // Okunan sayilar integer hale donusturuldukten sonra bu dizide saklanacak.
            string numbers;                      // Okunan sayilari tutar.
            string number = "";                  // Number eger diziye negatif tam sayi veya bir basamaktan fazla bir sayi girilirse yani mesela
                                                 // 90 girildi 90 i bir sayi olarak almak icin numbers stringinden number'a bu sayi okunup daha sonra
                                                 // integer veri tipine donusturulecek.

            // Diziye atacak sayilari kullanicidan alir fakat birden fazla sayi girilecekse aralarinda bosluk birakilarak girilmelidir.
            // Sayilar girilirken son kisimda bosluk birakilmamasina dikkat edilmelidir ! Aksi takdirde hata verecektir.
            // Cunku zaten asagida sonuna if kontrolu icin bosluk ekleniyor siz ekleyince de 2 bosluktan program patliyor.
            Console.Write("Please enter the numbers: ");
            numbers = Console.ReadLine();

            numbers += ' ';                      // Okunan dizinin sonuna bir bosluk ekliyorum cunku asagida dongude if kontrolu yapilirken lazim olacak.
                                                 // Bosluga gore okudugum icin son kisma bosluk eklemezsem son yazdigim sayiyi almaz o yuzden ekliyorum.

            // Okunan sayilar integer hale donusturulup diziye ekleniyor.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != ' ')
                {
                    number += numbers[i];
                }

                else
                {
                    array.Add(int.Parse(number));
                    number = "";
                }
            }

            Console.WriteLine(mean(array));
        }
    }
}
