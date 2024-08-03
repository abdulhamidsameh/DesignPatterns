using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.With_DP
{
    interface IQuackBehaviour
    {
        void PerformQuack();
    }
    class NormalQuack : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("I am Quacking Normal Quack");
        }
    }
    class Squaking : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("I am Squaking");
        }
    }

    class AbnormalQuack : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("I am Abnormal Quacking");
        }
    }
}
