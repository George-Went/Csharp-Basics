namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance Classes
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            Bycicle bycicle = new Bycicle();

            Console.WriteLine($"Vehicle : {vehicle.speed} ");
            Console.WriteLine($"Car wheels : {car.wheels}");
            Console.WriteLine($"Bycicle wheels : {bycicle.wheels}");

            // Abstract Classes
            Helicopter heli = new Helicopter();
            Plane biplane = new Plane();
            Console.WriteLine($"Heli flying type : {heli.flyingType}");
            Console.WriteLine($"Biplane flying type : {biplane.flyingType}");

            // Static Classes
            // Example is of the Math class
            double ans = Math.Sqrt(25);
            Console.WriteLine($"Sqaure root of 25 : {ans}");

            // Sealed class
            // Cannot be inherited 
            Walk hiker = new Walk();
            hiker.go();
            hiker.stop();
        }
    }
}
