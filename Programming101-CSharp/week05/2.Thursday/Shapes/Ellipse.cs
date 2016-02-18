using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Ellipse : Shape
    {
        public double RadiusX { get; protected set; }
        public double RadiusY { get; protected set; }
        public Point Center { get; protected set; }

        public Ellipse() { }
        public Ellipse(double radiusX, double radiusY, Point center)
        {
            this.RadiusX = radiusX;
            this.RadiusY = radiusY;
            this.Center = new Point(center);
        }

        public override double GetArea()
        {
            return Math.PI * RadiusX * RadiusY;
        }

        public override double GetPerimeter()
        {
            return Math.PI * (3 * (RadiusX + RadiusY) - Math.Sqrt((3 * RadiusX + RadiusY) * (RadiusX + 3 * RadiusY)));
        }

        public override string ToString()
        {
            return string.Format("Ellipse(RadiusX: {0}, RadiusY: {1}, Center: {2})", RadiusX, RadiusY, Center);
        }

        public override void Move(double x, double y)
        {
            Center.Move(x, y);
        }
    }
}
