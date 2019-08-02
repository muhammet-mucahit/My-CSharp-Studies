using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Program
    {
        // ORN: C(5,2) = 5! / 3! * 2! --> Iste burdaki islemde factorial fonksiyonu 5*4 islemi hesaplayip sonuc donderiyor cunku geri kalan alt tarafin
        // buyuk sayisiyla sadelesiyor.

        static int Factorial(int num1, int num2)
        {
            int sum = 1;

            for (int i = num1; i > num2; i--)
            {
                sum *= i;
            }

            return sum;
        }

        // Daha az is yapmak icin alt tarafin buyuk sayisini hesapliyor ve standart kombinasyon hesabini yapiyor.
        static int Combination(int up, int down)
        {
            int temp = up - down;

            if (temp > down)
            {
                return (Factorial(up, temp) / Factorial(down, 0));
            }
            
            return (Factorial(up, down) / Factorial(temp, 0));

        }
        
        static void Main(string[] args)
        {
            int first, second;
            
            // do-while yapisi eger alt sayi ust sayidan buyuk olursa kombinasyonda boyle bir sey gecerli olmadigi icin
            // kullanicidan yeni giris beklemek icin var yani girilen sayilar kabul edilmeyip bastan sayi istenecek.
            do
            {
                Console.Write("Please enter first number: ");
                first = int.Parse(Console.ReadLine());

                Console.Write("Please enter second number: ");
                second = int.Parse(Console.ReadLine());
            }
            while (second > first);

            Console.WriteLine(Combination(first, second));
        }
    }
}
