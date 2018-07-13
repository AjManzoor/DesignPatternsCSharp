using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark roast coffee";
        }

        public override string getDescription()
        {
            return description;
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}
