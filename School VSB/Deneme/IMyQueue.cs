using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public interface IMyQueue <T> : IMyCollection<T>
    {
        void Add(T item);
        T Get();
    }
}
