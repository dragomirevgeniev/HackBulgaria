using EventsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            NotifyCollection<Person> peopleNotifyColllection = new NotifyCollection<Person>
                ((sender, changeType, changedItemIndex, changedItemInfo) =>
                {
                    Console.Write("-->Handler: ");
                    switch (changeType)
                    {
                        case ItemChangeType.Add:
                            Console.WriteLine("Added item to collection on index {0}.", changedItemIndex);
                            break;
                        case ItemChangeType.Insert:
                            Console.WriteLine("Inserted item in collection on index{0}.", changedItemIndex);
                            break;
                        case ItemChangeType.Remove:
                            if (changedItemIndex == -1) Console.WriteLine("Collection items cleared.");
                            else Console.WriteLine("Removed item from collection being on index {0}.", changedItemIndex);
                            break;
                        case ItemChangeType.Replace:
                            Console.WriteLine("Replaced item in collection being on index {0}.", changedItemIndex);
                            break;
                        case ItemChangeType.ChangedProperty:
                            Console.WriteLine("Item on index {0} property {1} changed.", changedItemIndex, changedItemInfo);
                            break;
                        default:
                            break;
                    }
                });

            Person person1 = new Person("Gosho", 20);
            Person person2 = new Person("Pesho", 21);
            Person person3 = new Person("Ivan", 22);

            Console.WriteLine("Adding {0}.", person1);
            peopleNotifyColllection.Add(person1);
            Console.WriteLine("Adding {0}.", person2);
            peopleNotifyColllection.Add(person2);
            Console.WriteLine("Inserting {0} on index 1.", person3);
            peopleNotifyColllection.Insert(1, person3);
            Console.WriteLine("Changing {0} age to 30.", person1);
            person1.Age = 30;
            Console.WriteLine("Changing {0} age to 35.", person3);
            person3.Age = 35;
            Console.WriteLine("Removing {0}!", person2);
            peopleNotifyColllection.Remove(person2);
            Console.WriteLine("Changing {0} name to Todor.", person2);
            person2.Name = "Todor";
            Console.WriteLine("Clearing all items.");
            peopleNotifyColllection.Clear();
            Console.WriteLine("Adding {0}!", person1);
            peopleNotifyColllection.Add(person1);
            Console.WriteLine("Adding {0}!", person2);
            peopleNotifyColllection.Add(person2);
            Console.WriteLine("Replacing person on index 0 with {0}", person3);
            peopleNotifyColllection[0] = person3;
            Console.WriteLine("Adding {0}!", person1);
            peopleNotifyColllection.Add(person1);
            Console.WriteLine("All people in collection:");
            foreach (var person in peopleNotifyColllection)
            {
                Console.Write("{0} ", person);
            }

            Console.WriteLine();
        }
    }
}
