using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class LastDigitComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 10 > y % 10) return 1;
            else if (x % 10 < y % 10) return -1;

            return 0;
        }
    }

    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return (x ?? String.Empty).Length - (y ?? String.Empty).Length;
        }
    }

    class OddEvenComparer : IComparer<int?>
    {
        public int Compare(int? x, int? y)
        {
            if (x == null && y == null) return 0;
            else if (x == null) return -1;
            else if (y == null) return 1;

            if ((x % 2 + y % 2) % 2 == 1) return (int)(x % 2 - y % 2);
            else if (x % 2 == 0) return (int)(x - y);
            else if (x % 2 == 1) return (int)(y - x);

            return 0;
        }
    }

    public class ReverseComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            if (this.Compare(x, y) == 1) return -1;
            else if (this.Compare(x, y) == -1) return 1;

            return 0;
        }
    }
}
