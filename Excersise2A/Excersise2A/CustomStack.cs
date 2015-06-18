using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise2A
{
    class CustomStack<T>
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
    }
}
