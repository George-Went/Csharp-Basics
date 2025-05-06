using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{

    public class MethodArrows
    {
        // now with enums??
        public enum arrowhead_enum { steel, wood, obsidian }
        public enum fletching_enum { plastic, turkey, goose }

        public arrowhead_enum _arrowhead;
        public fletching_enum _fletching;
        public float _length;

        public MethodArrows()
        {
            _arrowhead = arrowhead_enum.steel;
            _length = 1;
            _fletching = fletching_enum.plastic;
        }

        public MethodArrows(string arrowhead, float length, string fletching)
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

