using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    interface IMyStack : IMyCollection
    {
        int Top { get; }
        int Pop();
        void Push(int item);
    }
}
