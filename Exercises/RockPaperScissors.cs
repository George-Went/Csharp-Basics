using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class RockPaperScissors
    {
        public static void Run()
        {
            Console.WriteLine("Rock Paper Scissors!");
            string input = "";

            Console.WriteLine("RPS");

            // 1 rock
            // 2 scissors
            // 3 paper

            Game game1 = new Game();
            Player player1 = new Player("wilma", 0);
            Player player2 = new Player();
            Player2 player_alt = new Player2("fred", 2);
            Console.WriteLine(player1.getscore());
            Console.WriteLine(player1.addToScore());
            Console.WriteLine(player1.getscore());
            player_alt._score = 123;
            player_alt._name = "haarodl";

            Console.WriteLine(player1.getname());
            Console.WriteLine(player_alt.getstuff());

            string val = game1.playRockPaperScissors(Game.rps_options.rock, Game.rps_options.scissors);
            Console.WriteLine($"Rock | Scissor : {val}");

            val = game1.playRockPaperScissors(Game.rps_options.rock, Game.rps_options.paper);
            Console.WriteLine($"Rock | Paper : {val}");

            val = game1.playRockPaperScissors(Game.rps_options.rock, Game.rps_options.rock);
            Console.WriteLine($"Rock | Rock : {val}");
        }

    }
    public class Game
    {
        public enum rps_options { rock, paper, scissors }
        public string playRockPaperScissors(rps_options p1, rps_options p2)
        {
            string result = "";

            if (p1 == p2)
            {
                result = "draw";
            }
            if (p1 == rps_options.paper)
            {
                if (p2 == rps_options.rock)
                {
                    return result = "win";
                }
                if (p2 == rps_options.scissors)
                {
                    return result = "lose";
                }
            }
            if (p1 == rps_options.rock)
            {
                if (p2 == rps_options.scissors)
                {
                    return result = "win";
                }
                if (p2 == rps_options.paper)
                {
                    return result = "lose";
                }
            }
            if (p1 == rps_options.scissors)
            {
                if (p2 == rps_options.paper)
                {
                    return result = "win";
                }
                if (p2 == rps_options.rock)
                {
                    return result = "lose";
                }
            }
            return result;
        }

    }
    public class Player
    {
        private string _name;
        private int _score;

        public Player()
        {
            _name = "undefined";
            _score = 0;
        }

        public Player(string name, int score)
        {
            _name = name;
            _score = score;
        }

        public string getname()
        {
            return _name;
        }
        public void setname(string name)
        {
            _name = name;
        }
        public int getscore()
        {
            return _score;
        }
        public int addToScore()
        {
            _score += 1;
            return _score;
        }

    }

    public class Player2
    {
        public string _name { get; set; }
        public int _score { get; set; }

        public Player2()
        {
            _name = "undefined";
            _score = 0;
        }

        public Player2(string name, int score)
        {
            _name = name;
            _score = score;
        }
        public string getstuff()
        {
            string val = _name + " | " + _score;
            return val;
        }
    }
}
