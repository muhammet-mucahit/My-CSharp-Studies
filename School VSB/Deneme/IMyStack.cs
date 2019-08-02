using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public interface IMyStack <T> : IMyCollection<T>
    {
        void Push(T item);
        T Pop();
        T Top { get; }
    }
}
