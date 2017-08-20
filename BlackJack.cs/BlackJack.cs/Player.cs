using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs
{
    class Player
    {
        public PlayingCard[] hand;
        public int cardsInHand { get; set; }

        public int points { get; set; }
        public string name { get; set; }

        public Player()
        {
            hand = new PlayingCard[5];
            cardsInHand = 0;
            points = 0;
        }

    }
}
