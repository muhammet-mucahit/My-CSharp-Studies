using System;

namespace HowMuchWordsInString
{
    /// <summary>
    ///  Bir metindeki kelime sayısını bulan kod.
    ///  Program gelismis degil gelistirilebilir.
    /// </summary>

    class Program
    {
        // Verilen metinde kac adet kelime oldugunu donduren fonksiyon.
        static int words(string txt)
        {
            // Kelime sayisi bu degiskende tutulacak.
            int counter = 0;

            // Metnimizin basindaki ve sonundaki bosluklari siliyoruz.
            txt.Trim();

            // Eger metin noktalama isaretiyle sonlanmamissa sonuna nokta ekliyoruz ki son kelimeyi de saysin.
            if (txt[txt.Length - 1] != '.' && txt[txt.Length - 1] != '?' && txt[txt.Length - 1] != '!')
                txt += '.';

            // Metnimizdeki noktalama isaretlerine veya bosluklara gore kac kelime oldugunu bulmaya calisiyoruz.
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == ' ' || txt[i] == '.' || txt[i] == '?' || txt[i] == '!')
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            // Metnimiz bu degiskenimizde tutulacak.
            string sentence;

            // Metnimizi kullanicidan aliyoruz.
            Console.Write("Please enter the sentence: ");
            sentence = Console.ReadLine();

            Console.WriteLine(words(sentence));

        }
    }
}
