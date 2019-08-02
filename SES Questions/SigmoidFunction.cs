using System;

namespace SigmoidFunction
{
    /// <summary>
    ///  Sigmoid fonksiyon hesaplayan program. 
    ///  Bu fonksiyon özellikle bir yapay sinir ağındaki sinir hücrelerinin (neurons) aktivasyonu için (ateşlenmesi, fire) oldukça kullanışlıdır.
    /// </summary>

    class Program
    {
        // Girilen sayinin sigmoid fonksiyonunu hesaplayan fonksiyon. 
        static double sigmoid(double x)
        {
            return (1 / (1 + Math.Exp(-x)));
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(sigmoid(num));
        }
    }
}
