namespace PretendDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CityDatabase db = new CityDatabase();

            Console.WriteLine("Hello, World!");
            Console.WriteLine("\nGET ALL");
            db.getAll();

            Console.WriteLine("\nADD");
            db.create("Tokyo", "Japan", 12345678);
            db.getAll();

            Console.WriteLine("\nREAD");
            db.read("London");
            db.read("Manchester");

            Console.WriteLine("\nUPDATE ");
            db.update("Paris", "Berlin", "Germany", 1000000);
            db.update("Shanghi", "Dublin", "Ireland", 1021312);
            Console.WriteLine("\nnew vals: ");
            db.getAll();

            Console.WriteLine("\nDELETE");
            db.delete("London");
            Console.WriteLine("\nnew vals: ");
            db.getAll();
        }
    }
}