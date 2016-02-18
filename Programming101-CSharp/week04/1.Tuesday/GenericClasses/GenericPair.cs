using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class GenericPair<T1, T2>
    {
        private readonly T1 first;
        private readonly T2 second;
        public T1 First { get { return first; } }
        public T2 Second { get { return second; } }

        public GenericPair() { }
        public GenericPair(T1 object1, T2 object2)
        {
            first = object1;
            second = object2;
        }

        public override bool Equals(object obj)
        {
            if (obj is GenericPair<T1, T2>)
            {
                GenericPair<T1, T2> pair = obj as GenericPair<T1, T2>;
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

        public static bool operator ==(GenericPair<T1, T2> firstPair, GenericPair<T1, T2> secondPair)
        {
            return object.Equals(firstPair, secondPair);
        }

        public static bool operator !=(GenericPair<T1, T2> firstPair, GenericPair<T1, T2> secondPair)
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
