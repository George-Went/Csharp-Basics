namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Grids grid2 = new Grids(10,10);
            grid2.DisplayNumberedGrid();

            // Create an array of four elements, and add values later
            // string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            // string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            // string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };



            //// define array 
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine($" car {i} : {cars[i]}");
            //}
            //// or 
            //Console.WriteLine(" \n alt --------------");
            //foreach (string car in cars)
            //{
            //    Console.WriteLine(car);
            //}
        }
    }
}
