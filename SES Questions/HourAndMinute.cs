using System;

namespace HourAndMinute
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, minute, addition_minute;

            // Simdinin saatini aliyoruz.
            Console.Write("Hour:     ");
            hour = int.Parse(Console.ReadLine());

            // Simdinin dakikasini aliyoruz.
            Console.Write("Minute:   ");
            minute = int.Parse(Console.ReadLine());

            // Eklemek istedigimiz dakika mikterini aliyoruz.
            Console.Write("Addition: ");
            addition_minute = int.Parse(Console.ReadLine());

            hour += addition_minute / 60; // Eklenecek dakikayi 60 a bolup saate ceviriyoruz ve su an ki saatimize ekliyoruz.
            minute += addition_minute - ((addition_minute / 60) * 60); // Mesela 500 dakika ekleyeceksek saate cevirince elimizde 8 saat olacak ama dakika
                                                                       // dakika bilgimiz olmayacak onu da burda hesaplayip suan ki dakikamiza ekliyoruz.

            hour += minute / 60; // Eger dakika eklendikten sonra 60'in uzerine ciktiysa bu bir saat demek oldugu icin bu miktari saatimize ekliyoruz.
            minute = minute % 60; // Ve mesela 61 olsa burdan 1 saat cikinca 1 dk kalir iste bu kalan dakikayi da normal dakikamiza setliyoruz.

            hour %= 24; // Eger saat 24 saatlik dilimi gecmisse yani mesela 23.00 olan bir saate 2 saat eklerseniz 25 olur ama boyle bir saat yok 1 var
                        // iste bu yuzden 24 ile modunu alip 24 saatlik dilime ceviriyoruz.

            Console.WriteLine("{0}.{1}", hour, minute);
        }
    }
}
