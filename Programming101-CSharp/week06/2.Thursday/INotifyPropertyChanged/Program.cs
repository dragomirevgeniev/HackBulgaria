using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged
{
    class Program
    {
        private static void PersonPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("{0} {1} property changed", sender.GetHashCode(), e.PropertyName);
        }
        
        static void Main(string[] args)
        {
            Person gosho = new Person();
            gosho.PropertyChanged += PersonPropertyChanged;
            gosho.Age = 20;        // Age property changed
            gosho.Name = "Gosho";  // Name property changed
            gosho.Age = 21;        // Age property changed
            gosho.Name = "Ivan";   // Name property changed
            gosho.City = "Vraca";  // City property changed
        }
    }
}

