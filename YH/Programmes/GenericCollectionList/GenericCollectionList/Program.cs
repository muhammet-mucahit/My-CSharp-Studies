using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            //array list her turlu veriyi icine alan bir dizidir.

            //ArrayList arr = new ArrayList();

            //arr.Add(123);
            //arr.Add("Mucahit");
            //arr.Add(true);

            //List<int> intList = new List<int>(); // list sadece istenilen veri tipini alir. yine dinamik bellek gibi
            //intList.Add(123);
            //intList.Add("Mucahit"); // Alamaz bunu sadece int

            List<Otomobil> envanter = new List<Otomobil>();

            Otomobil o1 = new Otomobil();

            o1.UreticiFirma = "RENAULT";
            o1.Model = "X6";
            o1.Renk = "Siyah";

            Otomobil o2 = new Otomobil();

            o2.UreticiFirma = "TOYOTA";
            o2.Model = "Corolla";
            o2.Renk = "Gri";

            envanter.Add(o1);
            envanter.Add(o2);

            Console.WriteLine("Envanterdeki Araclar");
            Console.WriteLine();

            foreach (Otomobil item in envanter)
            {
                item.Yazdir();
            }

            Console.WriteLine();

            envanter[0].Yazdir(); // boyle direkt olarak da cagirabiliyorsun. ArrayList de boyle bisey yoktu.
        }
    }
}
