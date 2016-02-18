using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Toy
    {
        protected string color;
        protected string size;

        public Toy()
        {
            RandomGenerator rand = new RandomGenerator();
            this.color = rand.RandomColor();
            this.size = rand.RandomSize();
        }

        public Toy(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} toy", size, color);
        }
    }
}
