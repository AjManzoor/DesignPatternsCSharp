using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "unknown beverage";

        public abstract string getDescription();

        public abstract double cost();
    }
}
