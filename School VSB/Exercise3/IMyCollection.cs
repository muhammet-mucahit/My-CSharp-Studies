using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public interface IMyCollection
    {
        bool IsEmpty { get; }
        bool IsFull { get; }
        int[] Emelents { get; }
        void Clear();
    }
}
