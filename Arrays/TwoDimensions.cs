using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class TwoDimensions{

        public void run()
        {
            int[,] array2 = { { 1, 3, 5 }, { 2, 4, 6 } };
            //or
            int[,] arr2v2 = new int[2, 3]; // new fixed array 2x3

            //assign
            arr2v2[0, 1] = 4;

            //Access
            Console.WriteLine(array2[1, 2]);
            Console.WriteLine(array2[1, 2]);

            array2[0, 1] = 3;

            // Get entire array
            for (int a = 0; a < array2.GetLength(0); a++)  // Rows
            {
                for (int b = 0; b < array2.GetLength(1); b++)  // Columns

                {
                    Console.Write($" {a},{b} : {array2[a, b]}" + " ");
                }
                Console.WriteLine();
            }
            // or
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }
        }

    }
}
