using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Vehicle
    {
        public int speed = 0; // field 
        public int wheels = 0; // this value is not overwritted by a child class due to field hiding  
        public void go()
        {
            Console.WriteLine("The vehicle is moving");
        }
        public void stop()
        {
            Console.WriteLine("The vehicle has stopped ");
        }
        public void AmountOfWheels()
        {
            Console.WriteLine($"This vehicle has {wheels} wheels");
        }
    }

    // Child Class "Car"
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bycicle : Vehicle
    {
        public int wheels = 2;
    }


}
