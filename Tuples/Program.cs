using System.Net.Security;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuples allow you to combine multiple elements into a single bundle 
            (string, int) points = ("wilma", 5);
            Console.WriteLine(points);

            // We can assing elements in a tuple to a value
            var score = (Name: "wilma", points: 17, level: 3);
            String player = score.Name;

            Console.WriteLine($"{player}");

            // and get specific values from the tuple 
            Console.WriteLine($"{score.points}");

            Soup soup1 = new Soup();
            soup1.makeSoup();
        }


    }
}
