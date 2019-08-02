using System;
using System.Collections.Generic;

namespace Top3IndexInArray
{
    /// <summary>
    ///  Dizideki en büyük 3 sayının toplamını döndüren kod.
    /// </summary>

    class Program
    {
        // Verilen dizideki en buyuk 3 sayinin toplamini veren fonksiyon.
        static int sum(List<int> arr)
        {
            // max her seferinde en buyuk sayiyi hesaplayacak.
            // location en buyuk sayinin indexini tutacakki daha sonra onu diziden temizleyeyim bir dahaki max sayi ondan bir kucugu olsun.
            // sum ise bu uc sayimizi toplayip bize sonucu verecek.
            int max, location = 0, sum = 0;

            // 3 en buyuk sayi istendigi icin for dongusu 3 kez donecek.
            for (int i = 0; i < 3; i++)
            {
                max = 0;
                foreach (int item in arr)
                {
                    if(item >= max)
                    {
                        max = item;
                        location = i;
                    }
                }
                sum += max;
                arr.Remove(max);    // bulunan max eleman diziden cikariliyor ki bir sonraki max elemani bulalim.
            }

            return sum;
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

            Console.WriteLine(sum(array));
        }
    }
}
