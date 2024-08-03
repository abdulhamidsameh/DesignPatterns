using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.With_DP
{
    interface IFlyBehaviour
    {
        void PerformFly();
    }

    class NoFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("No Wings to Fly");
        }
    }
    class NormalFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("I Flying With Normal Speed");
        }
    }
    class RocketSpeedFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("I am Flying With Rocket Speeeeeeeeeeeeeeeeeeeeeeeeed");
        }
    }
}
