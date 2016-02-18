using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Child : Person
    {
        protected Toy toy;
        private bool hasToy = false;
        
        public Child()
        {
            RandomGenerator rand = new RandomGenerator();
            this.gender = rand.RandomGender();
            this.name = rand.RandomName();
            if (new Random().Next(0, 6) > 2)
            {
                this.toy = new Toy();
                hasToy = true;
            }

            if (hasToy)
                isBoring = false;
        }

        public Child(string name, string gender, Toy toy)
        {
            this.name = name;
            if (gender == "male" || gender == "female")
                this.gender = gender;
            else
                this.gender = new RandomGenerator().RandomGender();
            if (toy != null)
                this.toy = toy;
                hasToy = true;

            if (hasToy)
                isBoring = false;
        }
        
        public override void DoDailyStuff()
        {
            if (toy != null)
                Console.WriteLine("{0} is playing with a {1}.", this.ToString(), toy.ToString());
            else
                Console.WriteLine("{0} is playing.", this.ToString());
        }
    }
}
