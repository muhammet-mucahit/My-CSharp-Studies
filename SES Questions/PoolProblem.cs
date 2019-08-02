using System;

namespace PoolProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taps = new int[3];

            // Her bir muslugun havuzu tek basina kac saatte doldurdugu bilgisi aliniyor.
            for (int i = 0; i < 3; i++) 
            {
                Console.Write("How many hours does {0}. tap fill the pool: ", i + 1);
                taps[i] = int.Parse(Console.ReadLine());
            }

            // ekok degiskeni ilk etapta 3 sayinin carpimina setleniyor.
            int ekok = taps[0] * taps[1] * taps[2];

            // Daha sonra ekok degiskeni kendi degerinden 0'a kadar iniyor ve eger daha kucuk bir ortak kat varsa onu bulmaya calisiyor yani gercek ekoku
            // bulmaya calisiyor.
            for(int i = ekok; i > 0; i--)
            {
                if(i % taps[0] == 0 && i % taps[1] == 0 && i % taps[2] == 0)
                {
                    ekok = i;
                }
            }

            int sum = 0;

            // Mesela 3, 8, 12 sayilarinin ekok'u 24 biz bunu 24k olarak dusunebiliriz. Simdi 24k/3 dersek 8k ilk muslugun bir nevi gucunu bulur.
            for (int i = 0; i < 3; i++)
            {
                taps[i] = ekok / taps[i];
                sum += taps[i];
            }

            // 3 muslugun ayni anda acilmasi durumunda havuzun dolma suresini ekrana basar.
            Console.WriteLine("{0} / {1} = {2}", ekok, sum, (double)ekok / (double)sum);
        }
    }
}
