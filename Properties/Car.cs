using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Car
    {
        private string _brand;
        private int _doors;
        private string _colour;

        public Car(string brand, int doors, string colour)
        {
            _brand = brand;
            _doors = doors;
            _colour = colour;
        }

        public void getInfo()
        {
            Console.WriteLine($"{_colour} {_brand} with {_doors} doors");
        }
    }

    class Car2
    {
        private string _brand;
        private int _doors;

        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        public int Doors { get => _doors; set => _doors = value; }
        public string Colour { get; set; }

        public Car2(string brand, int doors, string colour)
        {
            Brand = brand;
            Doors = doors;
            Colour = colour;
        }

        public void getInfo()
        {
            Console.WriteLine($"{Colour} {Brand} with {Doors} doors");
        }
    }

    class Car3
    {
        private string _brand;
        private int _doors;

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Nothing was entered");
                    _brand = "Default Value";
                }
                else
                {
                    _brand = value;
                }
            }
        }
        public int Doors { get => _doors; set => _doors = value; }
        public string Colour { get; set; }

        public Car3(string brand, int doors, string colour)
        {
            Brand = brand;
            Doors = doors;
            Colour = colour;
        }

        public void getInfo()
        {
            Console.WriteLine($"{Colour} {Brand} with {Doors} doors");
        }
    }

    class Car4
    {
        public string Brand { get; set; }
        public int Doors { get; set; }
        public string Colour { get; set; }

        public Car4(string brand, int doors, string colour)
        {
            Brand = brand;
            Doors = doors;
            Colour = colour;
        }

        public void getInfo()
        {
            Console.WriteLine($"{Colour} {Brand} with {Doors} doors");
        }
    }
}