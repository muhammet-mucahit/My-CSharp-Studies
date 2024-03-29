﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class MyQueue : IMyQueue
    {
        private int[] array = new int[5];
        private int first = 0; // Pointer to the last added element
        private int last = 0; // Pointer to the first added element
        private int size = 0; // Number of stored items


        public bool IsEmpty
        {
            get 
            {
                return size == 0;
            }
        }

        public bool IsFull
        {
            get
            {
                return size == array.Length;
            }
        }

        public void Clear()
        {
            size = 0;
            last = 0;
            first = 0;
        }

        public void Add(int item)
        {
            array[last++] = item;
            size++;

            if (last == array.Length)
                last = 0;
        }

        public int Get()
        {
            int result = array[first++];
            size--;

            if (first == array.Length) first = 0;

            return result;
        }
    }
}
