using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Add(1);   // 1
            queue.Add(2);   // 1 2
            queue.Add(3);   // 1 2 3
            queue.Add(4);   // 1 2 3 4
            queue.Add(5);   // 1 2 3 4 5
            queue.Get();    // 2 3 4 5
            ShowCollection(queue, "Queue");

            MyStack<string> stack = new MyStack<string>(10);
            stack.Push("A");    // A
            stack.Push("B");    // A B
            stack.Push("C");    // A B C
            stack.Push("D");    // A B C D
            stack.Push("E");    // A B C D E
            stack.Pop();        // A B C D

            ShowCollection(stack, "Stack");

            int[] items = { 1, 4, 7, 8, 5, 10, 2, 3, 6, 9 };

            Array.Sort(items, new EvenOddSizeComparer());
            ShowCollection(items, "EvenOddSizeComparer");

            Array.Sort(items, new OddEvenSizeDescComparer());
            ShowCollection(items, "OddEvenSizeDescComparer");

            Translator translator = new Translator();
            Console.WriteLine(translator.Translate("I.like.chips.and.beer.or.whiskey"));

            Console.WriteLine();
        }

        static void ShowCollection<T>(IEnumerable<T> collection, string message)
        {
            Console.WriteLine(message);

            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
