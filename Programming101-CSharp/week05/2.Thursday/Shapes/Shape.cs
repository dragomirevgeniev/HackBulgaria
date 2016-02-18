using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape : IMovable
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
        public abstract void Move(double x, double y);
    }
}
