namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises");
            //RockPaperScissors rps = new RockPaperScissors();
            //rps.check();
            //Inventory.Run();
            Console.Write("Select Exercise : ");
            string answer = "";
            
            while (answer != "stop")
            {
                answer = Console.ReadLine();
                Console.WriteLine($"You have entered : {answer}");
                switch (answer)
                {
                    case "1":
                        option1();
                        break;

                    case "2":
                        // Cards Exercise
                        Cards cards = new Cards();
                        cards.generatePack();
                        break;

                    case "3":
                        // Locked Box Exercise
                        LockedBox chest = new LockedBox();
                        chest.UseChest();
                        break;

                    case "4":
                        // Inventory Exercise
                        Inventory.Run();
                        break;

                    case "5":
                        // Enums and Soup
                        Soup soup = new Soup();
                        soup.makeSoup();
                        break;
                    
                    case "6":
                        // Rock Paper Scissors
                        RockPaperScissors.Run();
                        break;

                }
                if (answer != "stop")
                {
                    Console.WriteLine("Select Exercise: ");
                }
                
            }
            
        }
        public static void option1()
        {
            Console.WriteLine("Option 1!");
        }
        public void option2()
        {
            Console.WriteLine("Option 1");
        }
    }
}
