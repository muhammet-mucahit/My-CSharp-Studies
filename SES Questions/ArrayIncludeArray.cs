using System;

namespace ArrayIncludeArray
{
    /// <summary>
    ///  İki diziyi karşılaştırıp, birinci dizinin, ikinci dizinin bir parçası olup olmadığını bulan kod.
    /// </summary>

    class Program
    {
        static bool include(string first, string second)
        {
            // Esit cikan eleman oldukca counter bir artacak en son counter eger ilk dizinin size'ina esitse ilk dizi ikincide bulunuyor olacak.
            // k for dongusu icindeki i degiskenine setlenecek ki i'nin asil konumu j ile karsilastirma yapildiktan sonra kaybedilmesin.
            int counter = 0, k;

            for (int i = 0; i < second.Length; i++)
            {
                // Kucuk olan dizimizin ilk elemani buyuk olanda nerde bulunursa ortan itibaren kucuk dizinin boyutu kadar ileriye gidilip
                // karsilastirma yapilarak kucuk dizinin buyuk dizi de olup olmadigi arastiriliyor bulunamazsa hersey sifirlanip devam edilip
                // tekrar bu sart saglanirsa hersey bastan arastiriliyor ve boyle devam ediyor.
                if(first[0] == second[i])
                {
                    k = i;
                    for (int j = 0; j < first.Length; j++)
                    {
                        // k'yi kontrol ediyoruz cunku mesela ilk dizimiz meta olsun ikincisi de ahmet olsun bu durumda met kismina kadar dogru
                        // olacak ama son kisma gelindiginde ikinci dizimiz bittigi icin k bir artinca t den sonraki elemana yani olmayan bir
                        // elemana ulasmaya calisacak bu durumda da kod hata verecektir.
                        if (k < second.Length && first[j] == second[k])
                            counter++;
                        k++;
                    }
                }
                if (counter == first.Length)
                    break;
                counter = 0;
            }

            if (counter == first.Length)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            string farray;                      // Okunan ilk diziyi tutar.
            string sarray;                      // Okunan ikinci diziyi tutar.

            Console.Write("Please enter the first string : ");
            farray = Console.ReadLine();

            Console.Write("Please enter the second string: ");
            sarray = Console.ReadLine();

            Console.WriteLine(include(farray, sarray));
        }
    }
}
