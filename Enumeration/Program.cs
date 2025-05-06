using Classes;

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

            Cars car1 = new Cars("toyota", 5, "red");
            car1.getInfo();

            Cars2 car2 = new Cars2("volvo", "green", 3);
            car2.getInfo();

            Cars3 car3 = new Cars3(Cars3.brandEnum.Volvo, Cars3.colourEnum.Red, 4);


            LockedBox chest = new LockedBox();
            chest.UseChest();

        }

    }
}
