using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        public string Kind { get; protected set; }
        public abstract void Move();
        public abstract void Eat();
        public abstract void GiveBirth();
    }
}
