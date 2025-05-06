using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cars
    {
        string _brand;
        int _doors;
        string _colour;

        public Cars(string brand, int doors, string colour)
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


    // Using Enums 
    public class Cars2
    {
        public enum brandEnum { Toyota, Volvo, Vaxhall, Volkswagon }
        public enum colourEnum { Red, Blue, Green, Orange }

        brandEnum _brand;
        colourEnum _colour;
        int _doors;

        public Cars2()
        {
            _brand = brandEnum.Toyota;
            _colour = colourEnum.Red;
            _doors = 2;
        }
        public Cars2(string brand, string colour, int doors)
        {
            switch (brand)
            {
                case "Totoya":
                    _brand = brandEnum.Toyota;
                    break;
                case "Volvo":
                    _brand = brandEnum.Volvo;
                    break;
                case "Vaxhall":
                    _brand = brandEnum.Vaxhall;
                    break;
                case "Volkswagon":
                    _brand = brandEnum.Vaxhall;
                    break;
            }
            switch (colour)
            {
                case "Red":
                    _colour = colourEnum.Red;
                    break;
                case "Blue":
                    _colour = colourEnum.Blue;
                    break;
                case "Green":
                    _colour = colourEnum.Green;
                    break;
                case "Orange":
                    _colour = colourEnum.Orange;
                    break;
            }
            _doors = doors;
        }
        public void getInfo()
        {
            Console.WriteLine($"{_colour} {_brand} with {_doors} doors");
        }
    }


    // Using enums within object
    class Cars3
    {
        public enum brandEnum { Toyota, Volvo, Vaxhall, Volkswagon }
        public enum colourEnum { Red, Blue, Green, Orange }
        public int _doors;


        public Cars3(brandEnum brand, colourEnum colour, int doors)
        {
            Console.WriteLine($"{colour} {brand} with {doors} doors");
        }
    }
}
