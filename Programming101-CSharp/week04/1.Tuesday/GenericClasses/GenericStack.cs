using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class GenericStack<T>
    {
        private const int INITIAL_SIZE = 2;
        private const int SIZE_MULTIPLIER = 2;
        private T[] stacker;
        private int elementCount;

        public GenericStack()
        {
            stacker = new T[INITIAL_SIZE];
            elementCount = 0;
        }

        public GenericStack(int capacity)
        {
            stacker = new T[capacity];
            elementCount = 0;
        }

        public T Peek()
        {
            if (elementCount == 0)
            {
                throw new InvalidOperationException();
            }

            return stacker[stacker.Length - 1];
        }

        public T Pop()
        {
            if (elementCount == 0)
            {
                throw new InvalidOperationException();
            }

            T[] newArray = new T[stacker.Length - 1]; 
            T item = this.Peek();
            for (int i = 0; i < this.stacker.Length - 1; i++)
            {
                newArray[i] = stacker[i];
            }

            stacker = newArray;
            this.elementCount--;
            return item;
        }

        public void Push(T item)
        {
            this.TryGrow();
            this.stacker[this.elementCount] = item;
            this.elementCount++;
        }

        public void Clear()
        {
            if (this.elementCount > 0)
            {
                this.stacker = new T[INITIAL_SIZE];
                elementCount = 0;
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < stacker.Length; i++)
            {
                if (object.Equals(stacker[i], item))
                {
                    return true;
                }
            }

            return false;
        }

        private void TryGrow()
        {
            if (this.elementCount >= this.stacker.Length)
            {
                T[] newArray = new T[(this.stacker.Length * SIZE_MULTIPLIER)];
                for (int i = 0; i < this.stacker.Length; i++)
                {
                    newArray[i] = this.stacker[i];
                }

                this.stacker = newArray;
            }
        }
    }
}
