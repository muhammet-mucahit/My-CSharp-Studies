using System;
using System.Collections.Generic;

namespace MeanOfMaxAndMinEvenNumber
{
    /// <summary>
    ///  Dizideki çift sayıların en büyüğü ile en küçüğün ortalamasını bulan kod.
    /// </summary>

    class Program
    {
        // Girilen sayinin cift olup olmadigini soyleyen fonksiyon.
        static bool even(int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }

        static double mean(List<int> arr)
        {
            // max en buyuk sayiyi tutacak.
            // min en kucuk sayiyi tutacak. --> 999... sayisi yeterince buyuk oldugu dusunulerek rastgele girilmistir.
            int max = 0, min = 999999, counter = 0;

            foreach (int item in arr)
            {
                if(even(item))
                {
                    if (item > max) max = item;
                    if (item < min) min = item;
                    counter++;
                }           
            }

            // Hic cift sayi yoksa -1 donderilecek.
            if (counter == 0)
                return -1;

            return ((double)(max + min) / (double)2); // Dizideki tek sayilarin toplamini size'a bolunmesi bunlarin ortalamasini verir.      
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

            if(mean(array) == -1)
                Console.WriteLine("The array does not include any even numbers!");
            else
                Console.WriteLine(mean(array));
        }
    }
}
