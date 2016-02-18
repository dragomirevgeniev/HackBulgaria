using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        private double side;
        public double Side
        {
            get { return side; }
            protected set
            {
                Width = value;
                Height = value;
                side = value;
            }
        }

        public Square() { }
        public Square(double side)
        {
            this.Side = side;
        }

        public override string ToString()
        {
            return string.Format("Square(Side: {0}, Center: {1})", Side, Center);
        }

        public override void Move(double x, double y)
        {
            Center.Move(x, y);
        }
    }
}
