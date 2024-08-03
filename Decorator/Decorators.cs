using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    abstract class Decorator : Beverage
    {
        private protected Beverage _beverage;
        protected Decorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }

    class Milk : Decorator
    {
        public Milk(Beverage beverage)
            : base(beverage) 
        {
            Description = $"{_beverage.Description} With Milk";
            Coast = _beverage.Coast + 2;
        }
    }
    class Caramel : Decorator
    {
        public Caramel(Beverage beverage)
            : base(beverage) 
        {
            Description = $"{_beverage.Description} With Caramel";
            Coast = _beverage.Coast + 1.5M;
        }
    }

    class WippedCream : Decorator
    {
        public WippedCream(Beverage beverage)
            :base(beverage)
        {
            Description = $"{_beverage.Description} With Wipped Cream";
            Coast = _beverage.Coast + 1.3M;
        }
    }

    class WhiteMocha : Decorator
    {
        public WhiteMocha(Beverage beverage)
            : base(beverage)
        {
            Description = $"{_beverage.Description} With White Mocha";
            Coast = _beverage.Coast + 1.6M;
        }
    }
}
