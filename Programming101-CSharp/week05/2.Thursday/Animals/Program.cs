using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>() 
                { new Mammal(), new Dog(), new Cat(), new Shark(), new Bird(), new Owl(), new Reptile(), new Crocodile()};

            foreach (var creature in animals)
            {
                creature.Move();
                creature.Eat();
                creature.GiveBirth();

                if (creature is Mammal)
                {
                    Mammal m = creature as Mammal;
                    Console.WriteLine(m.Greet());
                }

                if (creature is Bird)
                {
                    Bird b = creature as Bird;
                    Console.WriteLine(b.MakeNest());
                }

                if (creature is Reptile)
                {
                    Reptile r = creature as Reptile;
                    Console.WriteLine(r.Greet());
                    Console.WriteLine(r.ChangeTemperature());
                }

                Console.WriteLine();
            }
        }
    }
}
