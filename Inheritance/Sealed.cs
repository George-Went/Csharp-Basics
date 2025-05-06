using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    sealed class Walk
    {
        public int speed = 3; // field 
        public void go()
        {
            Console.WriteLine("Started Walking");
        }
        public void stop()
        {
            Console.WriteLine("Stopped Walking");
        }
    }
}
