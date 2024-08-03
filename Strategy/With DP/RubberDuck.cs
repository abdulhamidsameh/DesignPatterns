using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.With_DP
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
            :base(new NoFly(),new Squaking())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("I am Rubber Duck :)");
        }
        
    }
}
