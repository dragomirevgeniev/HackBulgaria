using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class LineSegment
    {
        private readonly Point startPoint;
        private readonly Point endPoint;

        public Point StartPoint { get { return startPoint; } }
        public Point EndPoint { get { return endPoint; } }

        public LineSegment(Point startPoint, Point endPoint)
        {
            if (startPoint == endPoint)
            {
                throw new ArgumentException("Cannot create a line segment with zero length");
            }
            
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        LineSegment(LineSegment other)
        {
            this.startPoint = other.startPoint;
            this.endPoint = other.endPoint;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
        }

        public override string ToString()
        {
            return string.Format("Line[({0}, {1}), ({2}, {3})]", startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }

        public override bool Equals(object obj)
        {
            if (obj is LineSegment)
            {
                LineSegment ls = obj as LineSegment;
                if (!startPoint.Equals(ls.endPoint) || !endPoint.Equals(ls.startPoint))
                {
                    return false;
                }

                return true;
            }

            else return false;
        }

        public static bool operator==(LineSegment ls1, LineSegment ls2)
        {
            return ls1.Equals(ls2);
        }

        public static bool operator !=(LineSegment ls1, LineSegment ls2)
        {
            return !ls1.Equals(ls2);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + startPoint.GetHashCode();
                hash = hash * 23 + endPoint.GetHashCode();
                return hash;
            }
        }

        public static bool operator <(LineSegment ls1, LineSegment ls2)
        {
            return ls1.GetLength() < ls2.GetLength();
        }

        public static bool operator >(LineSegment ls1, LineSegment ls2)
        {
            return ls1.GetLength() > ls2.GetLength();
        }

        public static bool operator <=(LineSegment ls1, LineSegment ls2)
        {
            return ls1.GetLength() <= ls2.GetLength();
        }

        public static bool operator >=(LineSegment ls1, LineSegment ls2)
        {
            return ls1.GetLength() >= ls2.GetLength();
        }

        public static bool operator <(LineSegment ls, double length)
        {
            return ls.GetLength() < length;
        }

        public static bool operator <(double length, LineSegment ls)
        {
            return length < ls.GetLength();
        }

        public static bool operator >(LineSegment ls, double length)
        {
            return ls.GetLength() > length;
        }

        public static bool operator >(double length, LineSegment ls)
        {
            return length > ls.GetLength();
        }

        public static bool operator <=(LineSegment ls, double length)
        {
            return ls.GetLength() <= length;
        }

        public static bool operator <=(double length, LineSegment ls)
        {
            return length <= ls.GetLength();
        }

        public static bool operator >=(LineSegment ls, double length)
        {
            return ls.GetLength() >= length;
        }

        public static bool operator >=(double length, LineSegment ls)
        {
            return length >= ls.GetLength();
        }
    }
}
