using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.With_No_DP
{
    internal class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am Rubber Duck :)");
        }
        public new void Fly()
            => Console.WriteLine("No Wings To Fly");
        public new void Quack()
            => Console.WriteLine("I am Squaking");
    }
}
