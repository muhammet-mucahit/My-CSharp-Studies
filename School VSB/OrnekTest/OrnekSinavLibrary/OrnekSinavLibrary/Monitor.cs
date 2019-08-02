using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSinavLibrary
{
    public class Monitor
    {
        public void Borrowed(object sender, FilmEventArgs args)
        {
            Console.WriteLine("Informations are changed to Name = {0}, Borrowing To = {1}", args.Name, args.BorrowingTo);
        }
    }
}
