using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Adult : Person
    {
        protected Child child;
        private bool hasChild = false;
        private static RandomGenerator rand = new RandomGenerator();

        public Adult()
        {
            this.gender = rand.RandomGender();
            this.name = rand.RandomName();
            if (new Random().Next(0, 6) > 2)
            {
                this.child = new Child();
                hasChild = true;
            }

            if (hasChild)
                isBoring = false;
        }

        public Adult(string name, string gender, Child child)
        {
            this.name = name;
            if (gender == "male" || gender == "female")
                this.gender = gender;
            else
                this.gender = new RandomGenerator().RandomGender();
            if (child != null)
                this.child = child;
                hasChild = true;

            if (hasChild)
                isBoring = false;
        }
        
        public override void DoDailyStuff()
        {
            Console.WriteLine("{0} is working.", this.ToString());
        }
    }
}
