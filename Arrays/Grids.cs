using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Grids
    {
        // This class helps to generated and view 2D grids for board games 
        // should find a way to work inheritance into it
        
        private string[,] grid; // create default field

        // Default constructor
        public Grids() 
        {
            grid = new string[3, 3]; // set to 3x3

            int count = 0;
            // row
            for (int a = 0; a < grid.GetLength(0); a++)  // Rows
            {
                for (int b = 0; b < grid.GetLength(1); b++)  // Columns

                {
                    grid[a, b] = $"_";
                    count++;
                }
            }
        }
        
        // Set up a grid with a specific column/row count
        public Grids(int x, int y)
        {
            grid = new string[x, y]; // set to 3x3

            int count = 0;
            // row
            for (int a = 0; a < grid.GetLength(0); a++)  // Rows
            {
                for (int b = 0; b < grid.GetLength(1); b++)  // Columns

                {
                    grid[a, b] = $"_";
                    count++;
                }
            }
        }

        // GET 
        public string GetGrid(int x, int y)
        {   
            return grid[x, y].ToString();
        }
        // SET 
        public string SetGrid(int x, int y, string value)
        {
            grid[x,y] = value;
            return $"set {x},{y} : {value}";
        }

        // Display 
        public void displayGrid()
        {
            for (int a = 0; a < grid.GetLength(0); a++)  // Rows
            {
                for (int b = 0; b < grid.GetLength(1); b++)  // Columns

                {
                    Console.Write($" {a},{b} : {grid[a, b]}" + " ");
                }
                Console.WriteLine();
            }
        }


        // displays a number square thingy?
        // 1 2 3
        // 4 5 6
        // 7 8 9
        public void DisplayNumberedGrid()
        {
            int val = 1;
            for (int a = 0; a < grid.GetLength(0); a++)  // Rows
            {
                
                for (int b = 0; b < grid.GetLength(1); b++)  // Columns
                {
                    if (val < 10)
                    { 
                        Console.Write($" {val} "); 
                    }
                    else
                    {
                        Console.Write($"{val} ");
                    }
                    
                    val++;
                }
                Console.WriteLine();
               
            }
        }

        // Get grid val from number (coord > tile)
        public int GetTileVal(int row, int col)
        {

            int tileVal = row * grid.GetLength(1) + col + 1;
            return tileVal;
        }
        // get val from coor number (tile > coord)
        public (int x, int y) GetCoordinates(int tileNumber)
        {
            int cols = grid.GetLength(1);
            int row = (tileNumber - 1) / cols;
            int col = (tileNumber - 1) % cols;
            return (row, col);
        }

        // Get number from grid val

        // V2
        public string GetGrid2(int x, int y)
        {
            if (x >= grid.GetLength(0) || (y >= grid.GetLength(1)))
            {
                return "too high val!";
            }

            return grid[x, y].ToString();
        }
    }
}
