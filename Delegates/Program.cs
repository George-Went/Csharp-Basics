namespace Delegates
{

    // A delegate is a way to treat a method as a type of object
    // A delegate is a reference to a method
    // A delegate may hold a reference to a method 'That has not been defined yet'
    // Its like pre-booking / reserving a method name

    // 1 . Define a delegate
    public delegate void LogHandler(string message);

    // 2 . Create a method that can be bound to the LogHandler at some point in the future
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }
        public void LogToFile(string message)
        {
            Console.WriteLine("File Log: " + message);
        }
    }

    // Run
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 3. Create an instance of the method
            Logger logger_instance = new Logger();
            
            
            // we define an instance of the log handler delegate to run a Logger class 

            LogHandler logHandler = logger_instance.LogToConsole;
            logHandler("Logging");

            logHandler = logger_instance.LogToFile;
            logHandler("Logging");

            // MULTICAST 
            // We can also use multicast (bind multiple methods to a reference)
            LogHandler logHandler2 = logger_instance.LogToConsole;
            logHandler2 += logger_instance.LogToFile;
            logHandler("Multicast Logging");


            // Sorting Algorithm
            Sorting sort = new Sorting();
            sort.Run();

        }
    }
}
