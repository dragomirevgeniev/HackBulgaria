using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NotifyCollection
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private int age;

        public event PropertyChangedEventHandler PropertyChanged;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", this.name, this.age);
        }
    }
}
