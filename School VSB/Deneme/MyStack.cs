using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class MyStack <T> : IMyStack<T>
    {
        private T[] array;
        private int index = -1;

        public MyStack(int size)
        {
            array = new T[size];
        }

        public void Push(T item)
        {
            array[++index] = item;
        }

        public T Pop()
        {
            return array[index--];
        }

        public T Top
        {
            get { return array[index]; }
        }

        public bool IsEmpty
        {
            get { return index == -1; }
        }

        public bool IsFull
        {
            get { return index == array.Length - 1; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= Size)
                    Size = index * 2;

                return array[index];
            }
            set
            {
                if (index >= Size)
                    Size = index * 2;

                array[index] = value;
            }
        }

        public T[] Elements
        {
            get 
            {
                T[] result = new T[index + 1];
                Array.Copy(array, result, index + 1);
                return result;
            }
        }

        public MyCollectionState State
        {
            get 
            {
                if (IsEmpty)
                    return MyCollectionState.Empty;
                if (IsFull)
                    return MyCollectionState.Full;

                return MyCollectionState.PartiallyFull;
            }
        }

        public int Size
        {
            get
            {
                return array.Length;
            }
            set
            {
                if (value > array.Length)
                    Array.Resize(ref array, value);
                else if (value < array.Length)
                    throw new ApplicationException("You are attempting to shrink the collection!");
            }
        }

        public void Clear()
        {
            index = -1;
        }

        public void Sum(out int result)
        {
            if (typeof(T) == typeof(int))
            {
                result = 0;

                for (int i = 0; i <= index; i++)
                {
                    result += Convert.ToInt32(array[i]);
                }
            }
            else
            {
                throw new InvalidOperationException("This operation can be done only on integer collection!");
            }
        }

        public void Add(ref int number, int index)
        {
            if (typeof(T) == typeof(int))
            {
                number += Convert.ToInt32(this[index]);
            }
            else
            {
                throw new InvalidOperationException("This operation can be done only on integer collection!");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                    result.Append(' ');

                if (i <= index)
                    result.Append("'" + array[i] + "'");
                else
                    result.Append(array[i]);
            }

            return result.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyStackEnumerator(array, index);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class MyStackEnumerator : IEnumerator<T>
        {
            private int pos = -1;
            private int size;
            private T[] array;

            public MyStackEnumerator(T[] array, int size)
            {
                this.array = array;
                this.size = size;
            }

            public T Current
            {
                get
                {
                    return array[pos];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {
                // Done - no allocated resources
            }

            public bool MoveNext()
            {
                return pos++ < size;
            }

            public void Reset()
            {
                pos = 0;
            }
        }
    }
}
