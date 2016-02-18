using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mammal : Animal
    {
        public Mammal()
        {
            this.Kind = "mammal";
        }

        public override void Move()
        {
            Console.WriteLine("The {0} is walking.", Kind);
        }

        public override void Eat()
        {
            Console.WriteLine("The {0} is eating food", Kind);
        }

        public override void GiveBirth()
        {
            Console.WriteLine("The {0} is giving birth.", Kind);
        }

        public virtual string Greet()
        {
            return string.Format("The {0} is greeting.", Kind);
        }
    }
}
