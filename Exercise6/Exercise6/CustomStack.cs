using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Exercise6
{
    class CustomStack<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public T Peek()
        {
            T item = items[0];
            return item;
        }
        public T Pop()
        {
            T item = items[0];
            items.RemoveAt(0);
            return item;
        }
        public T Push(T item)
        {
            items.Insert(0, item);
            return item;
        }

        private bool isEmpty()
        {
            if (items.Count == 0)
                return true;
            else
                return false;
        }

        public void Add(T item)
        {
            Push(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
