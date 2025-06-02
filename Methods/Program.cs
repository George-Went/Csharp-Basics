namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting("george");
            Class1 exampleClass = new Class1();
            exampleClass.Goodbye("george");
            Program.Goodbye("greg");  // this one is static so it has to be called via its class
        }

        static void Greeting(string name)
        {
            Console.WriteLine($"Hello: {name}");
        }
        // this would need to be static as its class "Program" is also satic 
        // static classes need static methods!
        static void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye: {name}");
        }

    }
    public class Class1
    {
        public void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye: {name}");
        }

    }
}
