using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Whip : CondimentDecorator
    {


        public Whip(Beverage beverage)
            :base(beverage)
        {
            this.beverage = beverage;
        }


        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }


        public override double cost()
        {
            return beverage.cost() + 0.30;
        }
    }
}
