using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class DatetimeExample
    {
        public void run()
        {
            DateTime birthday = new DateTime(1996, 03, 17);
            Console.WriteLine($"Birthday : {birthday}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
        }
    }
}
