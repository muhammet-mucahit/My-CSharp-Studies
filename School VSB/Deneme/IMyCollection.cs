using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public interface IMyCollection<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }
        T this[int index] { get; set; }
        T[] Elements { get; }
        MyCollectionState State { get; }
        int Size { get; set; }
        void Clear();
        void Sum(out int result);
        void Add(ref int number, int index);
    }
}
