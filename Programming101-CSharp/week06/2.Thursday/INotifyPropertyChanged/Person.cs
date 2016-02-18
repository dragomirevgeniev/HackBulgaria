using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotifyPropertyChanged
{
    public class Person : System.ComponentModel.INotifyPropertyChanged
    {
        private string name;
        private int age;
        private string city;

        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {
            this.name = string.Empty;
            this.age = 0;
            this.city = string.Empty;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (this.PropertyChanged != null && value != this.name && this.name != null)
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
                if(this.PropertyChanged != null && value != this.age)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }

                this.age = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                if (this.PropertyChanged != null && value != this.city && this.city != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
                }

                this.city = value;
            }
        }

        public override int GetHashCode()
        {
            return (this.name.GetHashCode() * 13 + this.age.GetHashCode() * 17);
        }
    }
}
