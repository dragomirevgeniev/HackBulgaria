using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() { new Adult(), new Adult("Gosho", "male", new Child()), new Child(), new Child("Sasho", "male", new Toy()) };

            foreach (var person in people)
            {
                person.DoDailyStuff();
            }
        }
    }
}
