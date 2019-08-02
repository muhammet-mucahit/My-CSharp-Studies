using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    class Otomobil
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public void Yazdir()
        {
            Console.WriteLine("{0} firmasinin urettigi {1} modelinde ve {2} renginde olan bir otomobil.",UreticiFirma, Model, Renk);
        }
    }
}
