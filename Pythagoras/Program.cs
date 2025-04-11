using System.Runtime.InteropServices.Marshalling;

namespace Pythagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 4));

            // Caclulating Pythagorus
            Console.WriteLine(Pythagoras(4,5));

            // Score 
            Console.WriteLine($"Score 1 : {Score(3,5,7)}");
            Console.WriteLine($"Score 2 : {Score(46,5,2)}");
            Console.WriteLine($"Score 3 : {Score(7,2,5)}");
        }

        static int Add(int num1, int num2) 
        {
            return num1 + num2;
        }
        
        static double Pythagoras(int baseVal, int heightVal)
        {
            double ans = ((baseVal * heightVal) / 2);
            return ans;
        }

        static int Score(int prov, int county, int estate)
        {
            int provScore = (1 * prov);
            int countyScore = (2 * county);
            int estateScore = (3 * estate);

            int ans = (provScore + countyScore + estateScore);
            return ans;
        }

    }
}
