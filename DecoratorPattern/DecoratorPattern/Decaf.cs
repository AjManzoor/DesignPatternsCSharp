using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf coffee";
        }

        public override string getDescription()
        {
            return description;
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
