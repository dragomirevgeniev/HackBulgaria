using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Point : IMovable
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point() : this(0, 0) { }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point(Point other)
        {
            this.X = other.X;
            this.Y = other.Y;
        }

        public override string ToString()
        {
            return string.Format("Point({0}, {1})", X, Y);
        }

        public void Move(double x, double y)
        {
            X += x;
            Y += y;
        }
    }
}
