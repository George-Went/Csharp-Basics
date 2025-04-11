namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ProgramFlow.whileLoop();

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
    internal class ProgramFlow
    {
        // WHILE LOOP
        public static void whileLoop()
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("While Loop {0}", count);
                count = count + 1;
            }
        }
        // DO WHILE LOOP
        public static void doWhileLoop()
        {
            int count = 0;
            do
            {
                Console.WriteLine("Do While Loop {0}", count);
                count = count + 1;
            }
            while (count < 10);
        }
        //FOR LOOP
        public static void forLoop()
        {
            for (int count = 0; counter < 5; counter++)
            {
                Console.WriteLine("Generic for loop {0}", counter);
            }
        }
        // FOR LOOP - UNCONVENTIONAL
        static int counter;
        static void Initalise()
        {
            Console.WriteLine("Initilise");
            counter = 0;
        }

        static void Update()
        {
            Console.WriteLine("Update");
            counter = counter + 1;
        }
        static bool Test()
        {
            Console.WriteLine("Test");
            return counter < 5;
        }

        static void forLoopMain(string[] args)
        {
            for (Initalise(); Test(); Update())
            {
                Console.WriteLine("For Loop: {0}", counter);
            }
            Console.ReadKey();
        }
        // FOR EACH
        public static void forEachLoop()
        {
            string[] names = { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            
            // Classic Example
            for (int x = 0; x < names.Length; x++)
            {
                Console.WriteLine(x + " : " + names[x]);
            }
            Console.ReadKey(); // pauses application until user presses key
            
            // Shorter Example
            foreach (string name in names)
            {
                Console.WriteLine("check : " + name);

            }



            // You cant modify the iterating value however this way

            // foreach (string name in names)
            //  {
            //      name = name.ToUpper();
            //      Console.WriteLine(name);
            //  }

            // However if it iterating through a object it can change it as it is not a defined type
            //foreach (Person person in names)
            //  {
            //      person.name = name.ToUpper();
            //      Console.WriteLine(name);
            //  }

        }
        static string[] names = { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
        // BREAKS
        // This code will loop through until it hits "Lisa"
        // Then it will stop

        public static void breakStatement()
        {
            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine("break : " + names[index]);
                if (names[index] == "Lisa")
                    break;
            }
        }
        // CONTINUE
        // This will loop through until it hits lisa
        // Then skip lisa

        public static void continueStatment()
        {
            for (int index = 0; index < names.Length; index++)
            {
                if (names[index] == "Lisa")
                    continue;
                Console.WriteLine(names[index]);
            }
        }
    }
}
