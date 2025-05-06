using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Flying
    {
        public Flying() {
            Console.WriteLine("boo! Abstract");
        }

        public void takeOff()
        {
            Console.WriteLine("The vehicle is taking off");
        }
        public void land()
        {
            Console.WriteLine("The vehicle has landed");
        }
    }

    class Helicopter : Flying
    {
        public string flyingType = "Blades";
    }
    class Plane : Flying
    {
        public string flyingType = "wings";
    }
}
