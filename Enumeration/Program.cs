namespace Enumeration
{
    internal class Program
    {
        // Enums (enumeration)
        // its a small list of select options
        enum Season { Winter, Spring, Summer, Autumn };
        static void Main(string[] args)
        {

            // We can set enums to their specific value
            Season current = Season.Summer;

            if (current == Season.Winter) 
            {
                Console.WriteLine("Its winter, brrr!");
            }
            if (current == Season.Spring)
            {
                Console.WriteLine("Its spring!");
            }
            if (current == Season.Summer)
            {
                Console.WriteLine("Its summer!");
            }
            if (current == Season.Autumn)
            {
                Console.WriteLine("Its summer!");
            }

            LockedBox chest = new LockedBox();
            chest.UseChest();

        }

    }
}
