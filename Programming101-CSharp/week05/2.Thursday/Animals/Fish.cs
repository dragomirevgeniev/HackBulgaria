using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Fish : Animal
    {
        public Fish()
        {
            Kind = "fish";
        }

        public override void Move()
        {
            Console.WriteLine("The {0} is swimming.", Kind);
        }

        public override void Eat()
        {
            Console.WriteLine("The {0} is eating algae.", Kind);
        }

        public override void GiveBirth()
        {
            Console.WriteLine("The {0} is throwing the cavier.", Kind);
        }
    }
}
