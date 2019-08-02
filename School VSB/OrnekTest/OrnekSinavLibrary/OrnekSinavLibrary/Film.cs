using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSinavLibrary
{
    public class Film : IItem
    {
        public event EventHandler<FilmEventArgs> Borrowed;

        public string Name { get; set; }
        public int ID { get; set; }

        public ETypeOfFilm Genre { get; set; }
        public DateTime BorrowingFrom { get; set; }
        public DateTime BorrowingTo { get; set; }

        public void f_Borrowed(DateTime value)
        {
            BorrowingTo = value;

            if (Borrowed != null)
            { 
                FilmEventArgs args = new FilmEventArgs();
                args.Name = Name;
                args.BorrowingTo = value;
                Borrowed(this, args);
            }
        }

        public Film(string name, int id, ETypeOfFilm genre)
        {
            Name = name;
            ID = id;
            Genre = genre;
        }

        public void print()
        {
            Console.WriteLine("Film = {0}, {1}, {2}, {3}", Name, Genre, BorrowingFrom, BorrowingTo); 
        }
    }
}
