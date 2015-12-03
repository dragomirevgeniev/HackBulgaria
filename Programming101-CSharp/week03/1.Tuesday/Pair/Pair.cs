using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public class Pair
    {
        private readonly object first;
        private readonly object second;
        public object First { get { return first; } }
        public object Second { get { return second; } }

        public Pair() { }
        public Pair(Object object1, Object object2)
        {
            first = object1;
            second = object2;
        }

        public override bool Equals(object obj)
        {
            if (obj is Pair)
            {
                Pair pair = obj as Pair;
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

        public static bool operator ==(Pair firstPair, Pair secondPair)
        {
            return firstPair.Equals(secondPair);
        }

        public static bool operator!=(Pair firstPair, Pair secondPair)
        {
            return !firstPair.Equals(secondPair);
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
