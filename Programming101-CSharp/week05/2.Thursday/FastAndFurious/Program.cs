using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi a7 = new Audi();
            a7.Move(30000);
            Console.WriteLine("Audi a7 has passed {0} miles", a7.Mileage);
            Console.WriteLine("Audi a7 is eco friendly: {0}", a7.IsEcoFriendly(false));

            BMW m5 = new BMW();
            m5.Move(90000);
            Console.WriteLine("Bmw m5 has passed {0} miles", m5.Mileage);
            Console.WriteLine("Bmw m5 is eco friendly: {0}", m5.IsEcoFriendly(false));

            Volkswagen golf = new Volkswagen();
            golf.Move(135000);
            Console.WriteLine("Volkswagen golf has passed {0} miles", golf.Mileage);
            Console.WriteLine("Volkswagen golf is eco friendly: {0}", golf.IsEcoFriendly(false));

            Honda civic = new Honda();
            Console.WriteLine("Honda civic is eco friendly: {0}", civic.IsEcoFriendly(false));

            Skoda fabia = new Skoda();
            Console.WriteLine("Skoda fabia is eco friendly: {0}", fabia.IsEcoFriendly(false));
        }
    }
}
