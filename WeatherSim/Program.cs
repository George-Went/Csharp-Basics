namespace WeatherSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of days to simulate:");
            string input = Console.ReadLine();
            int days = int.Parse(input);
            Console.WriteLine($"Num1 : {days}");

            int[] temp = new int[days];
            string[] conditions = { "sun", "cloud", "rain", "snow" };
            string[] weatherConditions = new string[days];

            // Generate random
            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temp[i] = random.Next(0, 30);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
                Console.WriteLine(temp[i].ToString() + " | " + weatherConditions[i]);
            }
            Console.WriteLine(Average(temp));
        }

        static double Average(int[] temperature)
        {
            int sum = 0;
            foreach (int i in temperature)
            {
                sum += i;
            }
            Console.WriteLine($"sum : {sum}");
            Console.WriteLine(temperature.Length);
            double av = sum / temperature.Length;
            return temperature[0];
        }
    }
}
