using System;

namespace SomeTransactionsWithNames
{
    /// <summary>
    ///  Kullanicinin girdigi isimlerin baş harflerini ve her bir ismi ayri satirlara olacak sekilde ekrana yazdıran program.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Bir butun ismi tutacak degiskenimiz.
            string name;
            // Butun isim bolunerek 3 ayri isim haline getirildiginde isimleri tutacak dizi.
            string[] names = new string[3];

            // Ismi kullanicidan aliyoruz.
            Console.Write("Please enter some names: ");
            name = Console.ReadLine();

            // Asagida isimleri bolerken kontrolu bosluga gore yapacagim icin son ismi alabilmek adina stringimizin sonuna bir bosluk ekliyorum.
            name += " ";
            
            // Ana isim bolundukce parca isimlerimizi gecici olarak tutacak degiskenimiz.
            string temp = "";

            // Parcalanan isimlerin tutulacagi dizinin indexini olusturan variable.
            int j = 0;

            // Aldigimiz ismi boluyoruz.
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                    temp += name[i];
                else
                {
                    names[j] = temp;
                    temp = "";
                    j++;
                }
            }

            // Parcaladigimiz isimleri ayri satirlara olacak sekilde ekrana yazdiriyoruz.
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
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
