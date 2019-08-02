using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi___string_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilarMatrisi = new int[10];

            //sayilarMatrisi[1] = 15;
            //sayilarMatrisi[2] = 20;

            //Console.WriteLine(sayilarMatrisi[0]);
            //Console.WriteLine(sayilarMatrisi[1]);

            for (int i = 0; i < 10; i++)
            {
                sayilarMatrisi[i] = i;
                Console.WriteLine(sayilarMatrisi[i]);
            }
        }
    }
}
