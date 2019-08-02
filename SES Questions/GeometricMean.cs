using System;
using System.Collections.Generic;

namespace GeometricMean
{
    /// <summary>
    ///  Dizideki sayıların geometrik ortalamasını bulan kod.
    /// </summary>

    class Program
    {
        static double mean(List<int> arr)
        {
            long multiple = 1;   // multiple dizideki tum elemanlarin carpimini tutacak.
            double result;       // result geometrik ortalamayi yani sonucu tutacak.

            foreach (int item in arr)
            {
                multiple *= item;
            }

            // Burada direkt Sqrt() fonksiyonunu kullanamiyoruz cunku bu fonksiyon sadece karekok hesapliyor.
            // Bu yuzden burda us alan Pow() fonksiyonunun sag parametresine yani usse 1/size seklinde yazarsak yuksek dereceden kok almis oluruz.
            result = Math.Pow(multiple, (double)1 / (double)arr.Count);

            return result;          
        }

        static void Main(string[] args)
        {
            List<int> array = new List<int>();   // Okunan sayilar integer hale donusturuldukten sonra bu dizide saklanacak.
            string numbers;                      // Okunan sayilari tutar.
            string number = "";                  // Number eger diziye negatif tam sayi veya bir basamaktan fazla bir sayi girilirse yani mesela
                                                 // 90 girildi 90 i bir sayi olarak almak icin numbers stringinden number'a bu sayi okunup daha sonra
                                                 // integer veri tipine donusturulecek.

            // Diziye atacak sayilari kullanicidan alir fakat birden fazla sayi girilecekse aralarinda bosluk birakilarak girilmelidir.
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
