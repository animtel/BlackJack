using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs
{
    class Player
    {
        public PlayingCard[] Hand;
        public int CardsInHand { get; set; }

        public int Points { get; set; }
        public string Name { get; set; }

        public Player()
        {
            Hand = new PlayingCard[5];
            CardsInHand = 0;
            Points = 0;
        }

    }
}
