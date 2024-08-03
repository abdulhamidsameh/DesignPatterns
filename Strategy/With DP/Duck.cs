using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.With_DP
{
    internal abstract class Duck
    {
        protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            FlyBehaviour = flyBehaviour;
            QuackBehaviour = quackBehaviour;
        }

        public abstract void Display();

        public void Swim()
            => Console.WriteLine("I am Swimming");

        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        public void Fly(Action FlyAction)
        {
            FlyAction.Invoke();
        }
        public void Quack()
        {
            QuackBehaviour.PerformQuack();
        }
    }
}
