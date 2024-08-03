using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.With_No_DP
{
    internal abstract class Duck
    {
        public abstract void Display();

        public void Swim()
            => Console.WriteLine("I am Swimming");

        public void Fly()
            => Console.WriteLine("I am Flying");

        public void Quack()
            => Console.WriteLine("I am Quaking");
    }
}
