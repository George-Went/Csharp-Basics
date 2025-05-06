namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises");
            RockPaperScissors rps = new RockPaperScissors();
            rps.check();
            Inventory.Run();
        }
    }
}
