namespace Singeltone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GCard gCard01 = GCard.GetCard();
            //GCard gCard02 = GCard.GetCard();

            GCard gCard01 = GCard.SingeltonCard;
            GCard gCard02 = GCard.SingeltonCard;

            Console.WriteLine($"gCard01.GetHashCode() :{gCard01.GetHashCode()}");
            Console.WriteLine($"gCard02.GetHashCode() :{gCard02.GetHashCode()}");
        }
    }
}
