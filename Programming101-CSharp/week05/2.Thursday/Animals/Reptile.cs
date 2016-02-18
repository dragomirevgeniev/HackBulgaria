using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Reptile : Animal
    {
        protected int lowestBodyTemperature;
        protected int highestBodyTemperature;
        
        public Reptile()
        {
            this.Kind = "reptile";
            this.lowestBodyTemperature = 9;
            this.highestBodyTemperature = 43;
        }

        public override void Move()
        {
            Console.WriteLine("The {0} is crawling", Kind);
        }

        public override void Eat()
        {
            Console.WriteLine("The {0} is eating something", Kind);
        }

        public override void GiveBirth()
        {
            Console.WriteLine("The {0} is giving birth.", Kind);
        }

        public virtual string Greet()
        {
            return string.Format("The {0} is greeting.", Kind);
        }

        public virtual string ChangeTemperature()
        {
            Random rand = new Random();
            return string.Format("The {0} changed its temperature to {1:N2}°C!", Kind, rand.Next(lowestBodyTemperature, highestBodyTemperature) + rand.NextDouble());
        }
    }
}
