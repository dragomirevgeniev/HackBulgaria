using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class GenericDequeue<T>
    {
        private List<T> container;

        public GenericDequeue()
        {
            container = new List<T>();
        }

        public GenericDequeue(int capacity)
        {
            container = new List<T>(capacity);
        }

        public int Count()
        {
            return container.Count;
        }

        public void Clear()
        {
            container.Clear();
        }

        public bool Contains(T item)
        {
            return container.Contains(item);
        }

        public T RemoveFromFront()
        {
            T item = container[0];
            container.RemoveAt(0);
            return item;
        }

        public T RemoveFromEnd()
        {
            T item = container[container.Count - 1];
            container.RemoveAt(container.Count - 1);
            return item;
        }

        public void AddToFront(T item)
        {
            container.Insert(0, item);
        }

        public void AddToEnd(T item)
        {
            container.Add(item);
        }

        public T PeekFromFront()
        {
            return container[0];
        }

        public T PeekFromEnd()
        {
            return container[container.Count - 1];
        }
    }
}
