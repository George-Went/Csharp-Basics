namespace Properties
{
    internal class Properties
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car car1 = new Car("honda", 4, "red");
            car1.getInfo();

            Car2 car2 = new Car2("VW", 4, "blue");
            car2.getInfo();

            Car3 car3 = new Car3("mazda", 2, "green");
            car3.getInfo();

            Car4 car4 = new Car4("kia", 2, "orange");
            car4.getInfo();

            Customer jimbo = new Customer();
            Customer carl = new Customer();
            Console.WriteLine(jimbo.Name);

            jimbo.Name = "carl";
            jimbo.Password = "chicken";
            jimbo.showDetails();
            carl.showDetails();
            Customer.DisplayNumberOfCars();
        }
    }
}
