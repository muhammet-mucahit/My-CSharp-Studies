using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Note(object sender, string e)
        {
            Console.WriteLine(e);
        }

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.MultipleInsert += Note;

            inventory.Add("Part A", 42);
            inventory.Add("Part B", 100);
            inventory.Add("Part C", 50);
            inventory.Add("Part A", 5);

            Console.WriteLine(inventory.Get("Part A"));

            inventory.Save();

            Console.WriteLine();
        }
    }
}
