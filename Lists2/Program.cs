using System.Drawing;

namespace Lists2
{

    // Complex list with multiple properties  
    public class Shapes
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Sides { get; set; }

        public override string ToString()
        {
            return $"{Name}, Colour : {Colour} | Sides: {Sides}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BasicList();
            ComplexList();
        }

        // Basic example of list with 1 property 
        static void BasicList()
        {
            List<string> colours = ["orange", "purple", "cyan", "brown"];
            foreach (string x in colours)
            {
                Console.WriteLine(x);
            }
        }

        static void ComplexList()
        {
            List<Shapes> shapeList = new List<Shapes>
            {
                new Shapes { Name = "Triangle", Colour="Green", Sides=3},
                new Shapes { Name = "Square", Colour="Red", Sides=4},
                new Shapes { Name = "Pentagon", Colour="Blue", Sides=5}
            };
            foreach (Shapes x in shapeList)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
