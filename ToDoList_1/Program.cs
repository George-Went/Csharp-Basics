namespace ToDoList_1
{
    public class TaskObject
    {
        public string Task { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Task: {Task}, Description: {Description}";
        }
    }

    public class TaskList
    {
        List<TaskObject> taskListInstace = new List<TaskObject>
        {
            new TaskObject {Task = "feed cat", Description = "whiskers wet food!" },
            new TaskObject {Task = "learn c#", Description = "Still need to get database stuff" },
            new TaskObject {Task = "learn C++", Description = "have book to read" }
        };

        public void Read()
        {
            foreach (TaskObject singleTask in taskListInstace)
            {
                Console.WriteLine(singleTask.ToString());
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("\n--- TODO LIST ---");
            Console.WriteLine("1. View all tasks");
            Console.WriteLine("2. Add a task");
            Console.WriteLine("3. Update a task");
            Console.WriteLine("4. Delete a task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Console.WriteLine($"You have chosen : {choice}");

            switch (choice)
            {
                case "1": Read(); break;
                case "2": Create(); break;
                case "3": Update(); break;
                case "4": Delete(); break;
                case "5": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }

        static void Read()
        {
            string val = "get all!";
            foreach (Todo x in todoList)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
