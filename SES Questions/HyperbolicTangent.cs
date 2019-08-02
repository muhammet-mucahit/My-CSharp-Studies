using System;

namespace HyperbolicTangent
{
    /// <summary>
    ///  Hiperbolik tanjant hesaplayan program. 
    /// </summary>

    class Program
    {
        // Girilen sayinin hiperbolik tanjant'ini hesaplayan fonksiyon. 
        static double tanh(double u)
        {
            double a = Math.Exp(u);
            double b = Math.Exp(-u);

            return ((a - b) / (a + b));
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(tanh(num));
        }
    }
}
