using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    abstract class Person
    {
        protected string gender;
        protected string name;
        protected bool isBoring = true;

        public abstract void DoDailyStuff();
        public override string ToString()
        {
            return string.Format("{0}({1}; boring: {2})", name, gender, isBoring);
        }
    }
}
