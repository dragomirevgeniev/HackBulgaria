using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bird : Animal
    {
        public Bird()
        {
            this.Kind = "bird";
        }

        public override void Move()
        {
            Console.WriteLine("The {0} is flying.", Kind);
        }

        public override void Eat()
        {
            Console.WriteLine("The {0} is eating worms.", Kind);
        }

        public override void GiveBirth()
        {
            Console.WriteLine("The {0} is laying eggs.", Kind);
        }

        public virtual string MakeNest()
        {
            return string.Format("The {0} is making nest.", Kind);
        }
    }
}
