using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Score
    {
        public string name;
        public int points;
        public int level;

        // Base constructor
        public Score()
        {
            name = "Unknown";
            points = 1;
            level = 1;
        }

        // Override Constructor
        public Score(string n, int p, int l)
        {
            name = n;
            points = p;
            level = l;
        }

        public bool EarnedStar() => (points / level) > 1000;
    }
}
