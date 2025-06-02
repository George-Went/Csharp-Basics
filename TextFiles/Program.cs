namespace TextFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a file at "C:\Users\gepwe\source\repos\CsharpBasics\TextFiles\bin\Debug\net8.0\log.txt"
            Console.WriteLine("Start File Creation");
            CreateDirectroy();
     
        }
        static void createFile()
        {
            File.AppendAllText("log.txt", "hello log!" + "\n");
            Console.WriteLine("File at C:\\Users\\gepwe\\source\\repos\\CsharpBasics\\TextFiles\\bin\\Debug\\net8.0\\log.txt\"");
        }
        static void CreateFileInDirectory()
        {
            string directoryPath = @"C:\Logs";
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
            File.AppendAllText(filePath, "Hello Log!" + "\n");
            Console.WriteLine($"File at {directoryPath}");
            // Systems.IO is imported by default
        }
        static void CreateDirectroy()
        {
            string directoryPath = @"C:\Logs";
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {

                Directory.CreateDirectory(directoryPath);
            }
            
            File.AppendAllText(filePath, "Hello Log!" + "\n");
            Console.WriteLine($"File at {directoryPath}");
        }
    }
}
