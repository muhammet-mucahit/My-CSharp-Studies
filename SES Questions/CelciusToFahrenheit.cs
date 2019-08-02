using System;

namespace CelciusToFahrenheit
{
    /// <summary>
    ///  Celsius olarak verilen sıcaklık değerini Fahrenayt'a çeviren kod.
    /// </summary>

    class Program
    {
        // Verilen celcius sicakligi fahrenayt'a donusturen fonksiyon.
        static double fahrenheit(double cel)
        {
            double constant = 1.8;      // Formulden gelen sabit bir sayidir.
            return ((cel * constant) + 32);
        }

        static void Main(string[] args)
        {
            // Celcius sicaklik bu degiskende tutulacak.
            double celcius;

            Console.Write("Please enter the celcius: ");
            celcius = double.Parse(Console.ReadLine());

            // Fahrenayt degerini ekrana basiyoruz.
            Console.WriteLine(fahrenheit(celcius));
        }
    }
}
