using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class MyStack : IMyStack
    {
        private int[] array = new int[5];
        private int index = -1; // Pointer to top of the stack

        public bool IsEmpty
        {
            get
            {
                if (index == -1) return true;
                else return false;
                // return index == -1;
            }
        }

        public bool IsFull
        {
            get 
            {
                if (index == array.Length - 1) return true;
                else return false;

                // return index == array.Length - 1;
            }
        }

        public void Clear()
        {
            index = -1;
        }

        public int Top
        {
            get 
            {
                return array[index];
            }
        }

        public int Pop()
        {
            //int result = array[index];
            //index--;
            //return result;

            return array[index--];
        }

        public void Push(int item)
        {
            //array[index] = item;
            //index++;

            array[++index] = item;
        }
    }
}
