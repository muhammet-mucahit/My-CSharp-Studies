using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i > 0; i--)
            {
                if(i % 13 == 0)                
                    Console.WriteLine(i);
            }
        }
    }
}
