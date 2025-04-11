namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int value = 0;
            while (value != 10)
            {
                Console.WriteLine($"Value : {value}");
                value++;
            }

            // Continuous input loop until a certian value is entered 
            string name = "";
            while (name != "stop")
            {
                Console.Write("Enter a name (or type 'stop' to exit): ");
                name = Console.ReadLine();

                Console.WriteLine($"Name : {name}");
            }
            Console.WriteLine("Loop end");
            
        }
    }
}
