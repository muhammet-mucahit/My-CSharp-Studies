using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public interface IMyStack : IMyCollection
    {
        void Push(int item);
        int Pop();
        int Top { get; }
    }
}
