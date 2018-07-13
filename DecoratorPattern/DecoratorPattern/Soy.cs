using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Soy : CondimentDecorator
    {

        public Soy(Beverage beverage) : base(beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }


        public override double cost()
        {
            return beverage.cost() + 0.20;
        }


    }
}
