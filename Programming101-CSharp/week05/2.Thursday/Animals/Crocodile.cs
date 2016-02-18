using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Crocodile : Reptile
    {
        public Crocodile()
        {
            this.Kind = "crocodile";
            this.lowestBodyTemperature = 18;
            this.highestBodyTemperature = 32;
        }

        public override string Greet()
        {
            return string.Format("The {0} is greeting (R.I.P).", Kind);
        }
    }
}
