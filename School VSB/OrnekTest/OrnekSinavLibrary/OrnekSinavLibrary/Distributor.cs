using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrnekSinavLibrary
{
    public class Distributor
    {
        public List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void Print()
        {
            foreach (IItem item in items)
            {
                item.print();                 
            }
        }
    }
}
