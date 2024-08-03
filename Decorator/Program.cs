namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Espresso();
            Console.WriteLine(coffee);
            Milk coffeeWithMilk = new Milk(coffee);
            Console.WriteLine(coffeeWithMilk);
            Caramel coffeeWithMilkWithCaramel = new Caramel(coffeeWithMilk);
            Console.WriteLine(coffeeWithMilkWithCaramel);
            WippedCream coffeeWithMilkWithCaramelWithWippedCream = new WippedCream(coffeeWithMilkWithCaramel);
            Console.WriteLine(coffeeWithMilkWithCaramelWithWippedCream);
            WhiteMocha coffeeWithMilkWithCaramelWithWippedCreamWithWhiteMocha = new WhiteMocha(coffeeWithMilkWithCaramelWithWippedCream);
            Console.WriteLine(coffeeWithMilkWithCaramelWithWippedCreamWithWhiteMocha);

        }
    }
}
