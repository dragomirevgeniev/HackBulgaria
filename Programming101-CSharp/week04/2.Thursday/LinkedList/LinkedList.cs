using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    { 
        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value, Node next)
            {
                this.Value = value;
                this.Next = next;
            }
        }

        private int count;
        public Node Head { get; set; }
        public int Count { get { return count; } }

        public LinkedList()
        {
            this.Head = null;
            this.count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count) throw new ArgumentOutOfRangeException();
                Node curNode = this.Head;
                for (int i = 1; i <= index; i++)
                {
                    curNode = curNode.Next;
                }

                return curNode.Value;
            }

            set
            {
                if (index >= count) throw new ArgumentOutOfRangeException();
                Node curNode = this.Head;
                for (int i = 1; i <= index; i++)
                {
                    curNode = curNode.Next;
                }

                if (curNode == null) throw new ArgumentOutOfRangeException();
                curNode.Value = value;
            }
        }

        public void Add(T value)
        {
            if (this.Head == null)
            {
                this.Head = new Node(value, null);
            }
            else
            {
                Node curNode = this.Head;
                while (curNode.Next != null)
                {
                    curNode = curNode.Next;
                }

                curNode.Next = new Node(value, null);
            }

            count++;
        }

        public bool InsertAfter(T key, T value)
        {
            if (count == 0) return false;
            Node curNode = this.Head;
            while (!object.Equals(curNode.Value, key))
            {
                curNode = curNode.Next;
                if (curNode == null) return false;
            }
            curNode.Next = new Node(value, curNode.Next);
            count++;
            return true;
        }

        public bool InsertBefore(T key, T value)
        {
            if (count == 0) return false;
            Node lastNode = this.Head;
            Node curNode = this.Head;
            while (!object.Equals(curNode.Value, key))
            {
                lastNode = curNode;
                curNode = curNode.Next;
                if (curNode == null) return false;
            }

            if (object.ReferenceEquals(curNode, this.Head))
            {
                this.Head = new Node(value, this.Head);
                count++;
                return true;
            }
            else
            {
                lastNode.Next = new Node(value, lastNode.Next);
                count++;
                return true;
            }
        }

        public bool InsertAt(int index, T value)
        {
            if (index > count) return false;
            if (index == 0)
            {
                if (count == 0) this.Head = new Node(value, null);
                else this.Head = new Node(value, this.Head);
            }
            else
            {
                Node lastNode = this.Head;
                Node curNode = this.Head;
                for (int i = 1; i < index; i++)
                {
                    lastNode = curNode;
                    curNode = curNode.Next;
                }

                lastNode.Next = new Node(value, lastNode.Next);
            }

            count++;
            return true;
        }

        public bool Remove(T value)
        {
            if (count == 0) return false;
            Node lastNode = this.Head;
            Node curNode = this.Head;
            while (!object.Equals(curNode.Value, value))
            {
                lastNode = curNode;
                curNode = curNode.Next;
                if (curNode == null) return false;
            }

            if (object.ReferenceEquals(curNode, this.Head))
            {
                if (count == 1)
                {
                    this.Head = null;
                }
                else
                {
                    this.Head = this.Head.Next;
                }

                count--;
                return true;
            }
            else
            {
                lastNode.Next = curNode.Next;
                count--;
                return true;
            }
        }

        public bool RemoveAt(int index)
        {
            if (index >= count) return false;
            if (index == 0)
            {
                if (count == 1) this.Head = null;
                else this.Head = this.Head.Next;
            }
            else
            {
                Node curNode = this.Head;
                for (int i = 1; i < index; i++)
                {
                    curNode = curNode.Next;
                }
                curNode.Next = curNode.Next.Next;
            }

            count++;
            return true;
        }

        public void Clear()
        {
            if (count != 0)
            {
                Node curNode = this.Head;
                Node temp;
                while (curNode.Next != null)
                {
                    temp = curNode.Next;
                    curNode.Next = null;
                    curNode = temp;
                }

                this.Head = null;
                count = 0;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node curNode = this.Head;
            while (curNode != null)
            {
                yield return curNode.Value;
                curNode = curNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node curNode = this.Head;
            while (curNode != null)
            {
                yield return curNode;
                curNode = curNode.Next;
            }
        }
    }
}
