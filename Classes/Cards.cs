using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Cards
    {
        public enum suit_enum {club,spade,diamond,hearts };
        public enum rank_enum {two,three,four,five,six,seven,eight,nine,ten,jack,queen,king,ace};

        public suit_enum _suit;
        public rank_enum _rank;

        

        public Cards()
        {
            _suit = suit_enum.club;
            _rank = rank_enum.two;
        }

        public Cards(suit_enum suit, rank_enum rank)
        {
            _suit = suit;
            _rank = rank;
        }

        public bool getFace()
        {
            bool face = false;
            if (_rank == rank_enum.jack || _rank == rank_enum.queen || _rank == rank_enum.king || _rank == rank_enum.ace)
            {
                face = true;
            }
            return face;
        }

        public void generatePack()
        {

            foreach (suit_enum suit in Enum.GetValues(typeof(suit_enum)))
            {
                Console.WriteLine($"{suit.ToString()} -----------------");
                string suit_name = suit.ToString();
                foreach (rank_enum rank in Enum.GetValues(typeof(rank_enum)))
                {
                    string card_name = rank.ToString() + " of " + suit.ToString();
                    Console.WriteLine(card_name);
                }
            }
        }
        

    }
}
