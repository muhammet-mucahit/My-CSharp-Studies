using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    interface IMyCollection
    {
        bool IsEmpty { get; }
        bool IsFull { get; }
        void Clear();
    }
}
