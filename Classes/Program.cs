namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //run_arrow(); // static method so we can run like script
            //cardList();



        }

        public static void run_arrow()
        {
            Console.WriteLine("Order an arrow");

            // Create new instances of score
            Score first = new Score();
            Score second = new Score("wilma", 10000, 5);

            // see if they earned a star
            Console.WriteLine($"{first.name} passed? : {first.EarnedStar()}");
            Console.WriteLine($"{second.name} passed? : {second.EarnedStar()}");

            Console.Write("Arrowhead : 1.steel, 2.wood, 3.obsidian \n");
            string arrowhead_val = Console.ReadLine();

            Console.Write("Length : \n");
            string length_val = Console.ReadLine();

            Console.Write("Fletching : 1.plastic, 2.turkey, 3.goose \n");
            string fletching_val = Console.ReadLine();

            Arrow1 new_arrow_1 = new Arrow1(arrowhead_val, int.Parse(length_val), fletching_val);
            new_arrow_1.print();

            Arrow2 new_arrow_2 = new Arrow2(arrowhead_val, int.Parse(length_val), fletching_val);
            new_arrow_2.GetCost();
        }
        public static void cardList()
        {
            Cards card1 = new Cards();
            card1.generatePack();
        }
    }
}
