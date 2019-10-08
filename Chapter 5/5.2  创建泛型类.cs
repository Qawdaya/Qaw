using System.Collections;
using System.Collections.Generic;
using System;

namespace Wrox.ProCSharp.Generics
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }
        public LinkedListNode<T> Next { get; internal set; }
        public LinkedListNode<T> Prev { get; internal set; }
    }
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }

        public LinkedListNode<T> AddLast(T node)
        {
            var newNode = new LinkedListNode<T>(node);
            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            return newNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = First;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var list2 = new LinkedList<int>();
            list2.AddLast(1);
            list2.AddLast(3);
            list2.AddLast(5);

            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }

            var list3 = new LinkedList<string>();
            list3.AddLast("2");
            list3.AddLast("four");
            list3.AddLast("foo");

            foreach (string s in list3)
            {
                Console.WriteLine(s);
            }

        }

    }
}
