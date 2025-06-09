using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBinding.Data
{

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class DataObjectExample
    {
        public string OneWay { get; set; }
        public string TwoWay { get; set; }
        public string OneWaySource { get; set; }
    }
}
