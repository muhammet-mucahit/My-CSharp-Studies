using System;
using System.IO;
using System.Collections.Generic;

namespace BinaryToDecimalWithFile
{
    /// <summary>
    ///  Dosyadan okunan binary sayıları decimal sayılara çeviren kod.
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
            // Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            // 2.parametre dosyanın açılacağını,
            // 3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            FileStream fs = new FileStream("Binary.txt", FileMode.Open, FileAccess.Read);
            
            // Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            StreamReader sw = new StreamReader(fs);

            // Tek bir binary sayiyi tutacak dizi.
            int[] number;
            // Binary sayinin decimal sayiya cevrildikten sonra tutulacagi degisken.
            int decim;
            
            // Satır satır okuma işlemini gerçekleştirdik ve binary sayilarla birlikte decimal sayilari ekrana bastik.
            // Son satır okunduktan sonra okuma işlemini bitirdik.
            string text = sw.ReadLine();
            while (text != null)
            {
                number = new int[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    number[i] = (int)char.GetNumericValue(text[i]);
                }

                decim = convert(number);

                Console.WriteLine(text + " - " + decim);
                text = sw.ReadLine();
            }

            // İşimiz bitince kullandığımız nesneleri iade ettik.
            sw.Close();
            fs.Close();     
        }
    }     
}   
