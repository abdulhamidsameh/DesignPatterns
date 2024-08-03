using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.With_DP
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
            :base(new NormalFly(),new NormalQuack())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("I am Mallard Duck");
        }
    }
}
