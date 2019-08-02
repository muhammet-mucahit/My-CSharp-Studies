using System;

namespace FirstLetterOfNames
{
    /// <summary>
    ///  Kullanicinin girdigi isimlerin baş harflerini ekrana yazdıran program.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Isimleri tutacak string dizisi.
            string[] names = new string[3];

            // Isimleri kullanicidan aliyoruz.
            Console.WriteLine("Please enter some names: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}: ", i + 1);
                names[i] = Console.ReadLine();
            }

            // Aldigimiz isimlerin bas harflerini yazdiriyoruz.
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i][0]); 
            }

            // press any key continue... yazisinin altta gozukmesi icin ekliyorum.
            Console.WriteLine();
        }
    }     
}  
