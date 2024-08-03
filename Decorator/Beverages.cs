using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Abstract Component
    abstract class Beverage
    {
        public string Description { get; set; } = null!;
        public decimal Coast { get; set; }
        public override string ToString()
            => $"Description :{Description}\nCoast :{Coast:c}";
    }

    // Concerete Componenet
    class Espresso : Beverage
    {
        public Espresso()
            :base()
        {
            Description = "Espereso Coffee";
            Coast = 2.5M;
        }
    }

    class MediumRoast : Beverage
    {
        public MediumRoast()
        {
            Description = "Medium Roast Coffee";
            Coast = 4.5M;
        }
    }

    class Decafe : Beverage 
    {
        public Decafe()
        {
            Description = "Decafe Coffee";
            Coast = 4.0M;
        }
    }

    class DarkRoast : Beverage 
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
            Coast = 2.5M;
        }
    }
}
