using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Point Vertex1 { get; protected set; }
        public Point Vertex2 { get; protected set; }
        public Point Vertex3 { get; protected set; }

        public Triangle() { }
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.Vertex1 = vertex1;
            this.Vertex2 = vertex2;
            this.Vertex3 = vertex3;
        }

        public override double GetArea()
        {
            return Math.Abs((Vertex1.X * (Vertex2.Y - Vertex3.Y) + Vertex2.X * (Vertex3.Y - Vertex1.Y) + Vertex3.X * (Vertex1.Y - Vertex2.Y)) / 2);
        }

        public override double GetPerimeter()
        {
            double a = Math.Sqrt(Math.Pow(Vertex1.X - Vertex2.X, 2) + Math.Pow(Vertex1.Y - Vertex2.Y, 2));
            double b = Math.Sqrt(Math.Pow(Vertex2.X - Vertex3.X, 2) + Math.Pow(Vertex2.Y - Vertex3.Y, 2));
            double c = Math.Sqrt(Math.Pow(Vertex3.X - Vertex1.X, 2) + Math.Pow(Vertex3.Y - Vertex1.Y, 2));
            return a + b + c;
        }

        public override string ToString()
        {
            return string.Format("Triangle({0}, {1}, {2})", Vertex1, Vertex2, Vertex3);
        }

        public override void Move(double x, double y)
        {
            Vertex1.Move(x, y);
            Vertex2.Move(x, y);
            Vertex3.Move(x, y);
        }
    }
}
