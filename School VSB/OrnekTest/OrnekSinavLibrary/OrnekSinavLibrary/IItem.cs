using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSinavLibrary
{
    public interface IItem
    {
        string Name { get; set; }
        int ID { get; set; }
        void print();
    }
}
