using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{

    public class Arrow1
    {
        string _arrowhead;
        float _length;
        string _fletching;

        // Blank constructor - used to set "default" values
        public Arrow1()
        {
            _arrowhead = "steel";
            _length = 1;
            _fletching = "plastic";
        }
        // Set Constructor

        // this is a type of overloading
        public Arrow1(string arrowhead, float length, string fletching)
        {
            _arrowhead = arrowhead;
            _length = length;
            _fletching = fletching;
        } 

        public void print()
        {
            Console.WriteLine($"{_arrowhead} | {_length} | {_fletching}");
        }
    }

    // This does the same thin as arrow1 but with enums 
    public class Arrow2
    {
        // now with enums??
        public enum arrowhead_enum {steel,wood,obsidian}
        public enum fletching_enum {plastic,turkey,goose }

        public arrowhead_enum _arrowhead;
        public fletching_enum _fletching;
        public float _length;

        public Arrow2()
        {
            _arrowhead = arrowhead_enum.steel;
            _length = 1;
            _fletching = fletching_enum.plastic;
        }

        public Arrow2(string arrowhead, float length, string fletching)
        {
            switch (arrowhead)
            {
                case "steel":
                    _arrowhead = arrowhead_enum.steel;
                    break;
                case "wood":
                    _arrowhead = arrowhead_enum.wood;
                    break;
                case "obsidian":
                    _arrowhead = arrowhead_enum.obsidian;
                    break;
            }
            
            _length = length;

            switch (fletching)
            {
                case "plastic":
                    _fletching = fletching_enum.plastic;
                    break;
                case "turkey":
                    _fletching = fletching_enum.turkey;
                    break;
                case "goose":
                    _fletching = fletching_enum.goose;
                    break;
            }
        }

        public float GetCost()
        {
            float a = 0;
            float b = 0;
            float c = 0;

            float total_cost = 0;

            // calculate arrowhead cost
            switch (_arrowhead)
            {
                case arrowhead_enum.steel:
                    Console.WriteLine("FLINT AND S T E E L");
                    a = 10;
                    break;
                case arrowhead_enum.wood:
                    Console.WriteLine("WOOD");
                    a = 3;
                    break;
                case arrowhead_enum.obsidian:
                    Console.WriteLine("OBSIDIAN");
                    a = 5;
                    break;
            }
            // calculate length cost
            b = (_length * 0.05f);

            total_cost = a + b + c;

            return total_cost;
        }
    }
}
