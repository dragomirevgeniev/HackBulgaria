using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Ellipse
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                RadiusX = value;
                RadiusY = value;
                radius = value;
            }
        }

        public Circle() { }
        public Circle(double radius, Point center)
        {
            this.Radius = radius;
            this.Center = new Point(center);
        }

        public override string ToString()
        {
            return string.Format("Circle(Radius: {0}, Center: {1})", Radius, Center);
        }

        public override void Move(double x, double y)
        {
            Center.Move(x, y);
        }
    }
}
