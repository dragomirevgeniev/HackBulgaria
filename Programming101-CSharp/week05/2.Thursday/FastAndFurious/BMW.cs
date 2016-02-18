using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    class BMW : Car
    {
        public BMW()
        {
            this.mileage = 0;
        }

        public int Mileage { get { return this.mileage; } }
        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
    }
}
