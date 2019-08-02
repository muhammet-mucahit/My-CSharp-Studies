using OrnekSinavLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace OrnekSinav
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor();

            Film film2 = new Film("The Drop", 179314, ETypeOfFilm.Drama);
            film2.Borrowed += monitor.Borrowed;
            film2.BorrowingFrom = DateTime.Now;
            film2.BorrowingTo = DateTime.Now.AddDays(5);
            //film2.f_Borrowed(DateTime.Now);
            //Console.WriteLine(film2.BorrowingTo);

            Audio aud1 = new Audio();
            aud1.Name = "Shape of You";
            aud1.ID = 321;
            aud1.Lenght = 20;
            aud1.Author = "Ed Sheeran";

            Audio aud2 = new Audio();
            aud2.Name = "Rolling in the deep";
            aud2.ID = 194;
            aud2.Lenght = 25;
            aud2.Author = "Adele";

            Film film1 = new Film("Parker", 159621, ETypeOfFilm.Action);
            film1.BorrowingFrom = DateTime.Now;
            film1.BorrowingTo = DateTime.Now.AddDays(5);

            Distributor distributor = new Distributor();

            distributor.AddItem(aud1);
            distributor.AddItem(aud2);
            distributor.AddItem(film1);
            distributor.AddItem(film2);

            distributor.Print();
            
            Console.WriteLine();
        }
    }
}
