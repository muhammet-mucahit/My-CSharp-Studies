using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSinavLibrary
{
    public class Audio : IItem
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public int Lenght { get; set; }
        public string Author { get; set; }

        public void print()
        {
            Console.WriteLine("Audio = {0}, {1}", Name, Author); 
        }
    }
}
