namespace Lists
{
    internal class Program
    {

        class ArrayExample
        {
            public void Run()
            {
                // This 
                int days = 7;
                string[] week = new string[days];

                foreach (string i in week)
                {
                    Console.WriteLine(i);
                    week[(days - 1)] = "sdf";
                }

                for (int i = 0; i < days; i++)
                {
                    Console.WriteLine($"day {week[i]}");
                }

                string[] test = new string[3];
                int count = 0;

                foreach (string i in test)
                {
                    Console.WriteLine($"{count} : {i}");
                    count++;
                }
            }
        }

        static void Main(string[] args)
        {
            //lists are a type of object(they are also a generic ?)
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("green");
            colors.Add("blue");
            colors.Add("yellow");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            // Remove from list ----------------------------------------------
            colors.Remove("yellow");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // initlise list with items ----------------------------------------------
            Console.WriteLine();
            List<string> colors2 = ["orange", "purple", "cyan", "brown"];

            foreach (string color in colors2)
            {
                Console.WriteLine(color);
            }

            // Sorting lists ----------------------------------------------
            Console.WriteLine();
            List<int> numbers = new List<int> { 4, 5, 2, 7, 1, 9, 12 };
            Console.WriteLine("Unsorted List");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();
            Console.WriteLine("Sorted List");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            // Finidng numbers
            numbers.FindAll(x => x >= 10);

            //Comparing to a array
            ArrayExample example = new ArrayExample();
            example.Run();


        }
      
    }
}
