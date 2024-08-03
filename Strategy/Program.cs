using Strategy.With_DP;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallerdDuck = new MallardDuck();
            mallerdDuck.Display();
            mallerdDuck.Swim();
            mallerdDuck.Quack();
            mallerdDuck.Fly(() => Console.WriteLine("I Flying With Normal Speed"));

            Console.WriteLine("********************************");

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Swim();
            rubberDuck.Quack();
            rubberDuck.Fly(() => Console.WriteLine("No Wings to Fly"));

            Console.WriteLine("*************************************************");
            Console.WriteLine("************* Hunting Mode On *******************");
            Console.WriteLine("*************************************************");

            mallerdDuck.FlyBehaviour = new RocketSpeedFly();
            mallerdDuck.QuackBehaviour = new AbnormalQuack();
            mallerdDuck.Quack();
            mallerdDuck.Fly(() => Console.WriteLine("I am Flying With Rocket Speeeeeeeeeeeeeeeeeeeeeeeeed"));



        }
    }
}
