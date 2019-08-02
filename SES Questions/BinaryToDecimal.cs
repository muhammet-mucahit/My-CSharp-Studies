using System;

namespace BinaryToDecimal
{
    /// <summary>
    ///  Binary bir sayıyı 10'luk tabana (Decimal) çeviren program.
    /// </summary>

    class Program
    {
        // Girilen binary sayiyi decimal sayiya ceviren fonksiyon. 
        static int convert(int[] number)
        {
            int num = 0;
            int[] temp = new int[number.Length]; // Diziyi ters cevirebilmek icin gecici dizi tanimliyorum.
            int j = number.Length - 1;           // Bu degisken asil dizimizi ters cevirirken tersten indexlemek icin tanimlandi.

            // Diziyi ters ceviriyorum cunku asagida dongude i indexiyle 2'nin us lerini alip toplayarak decimal elde edecegim.
            for (int i = 0; i < number.Length; i++) 
            {
                temp[i] = number[j];
                j--;
            }

            // Dizimiz artik ters bir sekilde temp dizisinin icinde ve islemlerime temp uzerinden devam ediyorum.
            // Ikilik tabandaki sayimizi decimal sayiya cevirip num degiskenine atiyorum. Num bizim decimal sayimiz yani sonucumuz olacak.
            for (int i = 0; i < temp.Length; i++)
            {
                num += temp[i] * (int)Math.Pow(2, i);
            }

            return num;
        }

        static void Main(string[] args)
        {
            string numbers;

            Console.Write("Please enter a binary number: ");
            numbers = Console.ReadLine();

            int[] number = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                number[i] = (int)char.GetNumericValue(numbers[i]);
            }

            Console.WriteLine(convert(number));
        }
    }
}
