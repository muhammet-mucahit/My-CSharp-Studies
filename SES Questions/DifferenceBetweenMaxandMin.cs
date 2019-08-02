using System;
using System.Collections.Generic;

namespace DifferenceBetweenMaxandMin
{
    /// <summary>
    ///  Dizideki en büyük ve en küçük sayılar arasındaki farkı bulan kod.
    /// </summary>

    class Program
    {
        static int difference(List<int> arr)
        {
            // max en buyuk sayiyi tutacak.
            // min en kucuk sayiyi tutacak. --> 999... sayisi yeterince buyuk oldugu dusunulerek rastgele girilmistir.
            int max = 0, min = 999999;

            foreach (int item in arr)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }

            return (max - min);           
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

            Console.WriteLine(difference(array));
        }
    }
}
