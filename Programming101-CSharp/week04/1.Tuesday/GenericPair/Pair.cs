using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public class Pair<T>
    {
        private readonly object first;
        private readonly object second;
        public object First { get { return first; } }
        public object Second { get { return second; } }

        public Pair() { }
        public Pair(T object1, T object2)
        {
            first = object1;
            second = object2;
        }

        public override bool Equals(object obj)
        {
            if (obj is Pair<T>)
            {
                Pair<T> pair = obj as Pair<T>;
                if (!first.Equals(pair.first))
                {
                    return false;
                }

                if (!second.Equals(pair.second))
                {
                    return false;
                }

                return true;
            }

            else return false;
        }

        public static bool operator ==(Pair<T> firstPair, Pair<T> secondPair)
        {
            return object.Equals(firstPair, secondPair);
        }

        public static bool operator !=(Pair<T> firstPair, Pair<T> secondPair)
        {
            return !object.Equals(firstPair, secondPair);
        }

        public override string ToString()
        {
            return string.Format("Pair({0}, {1})", First, Second);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + First.GetHashCode();
                hash = hash * 23 + Second.GetHashCode();
                return hash;
            }
        }
    }
}
