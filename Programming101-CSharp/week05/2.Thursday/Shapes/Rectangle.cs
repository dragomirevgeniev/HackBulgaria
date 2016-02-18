using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        public Point Center { get; protected set; }

        public Rectangle() { }
        public Rectangle(double width, double heigth, Point center)
        {
            this.Width = width;
            this.Height = heigth;
            this.Center = center;
        }   

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return string.Format("Rectangle(Width: {0}, Height: {1}, Center: {2})", Width, Height, Center);
        }

        public override void Move(double x, double y)
        {
            Center.Move(x, y);
        }
    }
}
