using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ThreeDimensions
    {
        internal class ThreeDimension
        {
            public void run()
            {
                // initilising arrays
                int[,,] array3 = { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 2, 3 }, { 4, 5 }, { 5, 6 } }, { { 10, 20 }, { 30, 40 }, { 50, 60 } } };
                //or
                int[,,] arr3v2 = new int[3, 3, 3]; // new fixed array 2x3

                //assign
                arr3v2[0, 1, 2] = 4;

                //Access

                // Get entire array
                // Note that getLength will work based on the
                for (int x = 0; x < array3.GetLength(0); x++)  // Rows
                {
                    for (int y = 0; y < array3.GetLength(1); y++)  // Columns
                    {
                        for (int z = 0; z < array3.GetLength(2); z++)  // depth?
                        {
                            Console.Write($" {x},{y},{z} : {array3[x, y, z]}" + " ");
                        }
                    }
                }

                // can also still use foreach
                foreach (int i in array3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
