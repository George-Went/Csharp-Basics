namespace Structs
{
    internal class Program
    {

        // Structs vs Classes
        // Structs are value types, classes are reference types 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Property structs
            Point p1 = new Point(40, 50);
            p1.Display();

            Point p2 = new Point(20, 10);
            double distance = p1.DistanceTo(p2);

            p1.Display();
            p2.Display();
            Console.WriteLine($"Distance between p1 and p2 : {distance}");

            Console.WriteLine("Datetime -------------------------------- ");
            DatetimeExample datetimeExample = new DatetimeExample();
            datetimeExample.run();
        }
        public struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Display()
            {
                Console.WriteLine($"Point ({X},{Y})");
            }

            public double DistanceTo(Point other)
            {
                double dx = other.X - X;
                double dy = other.Y - Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public struct PointStructField
        {
            public int X;
            public int Y;

            public PointStructField(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Display()
            {
                Console.WriteLine($"Point ({X},{Y})");
            }
        }
    }
    


}

