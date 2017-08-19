using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs
{
    class Model
    {
        static Player[] players = new Player[5];
        static int point = 0;

        public static PlayingCard[] GenerateDeck()
        {
            PlayingCard[] deck = new PlayingCard[52]; // generate array of card
            int counter = 0; // counter each card in array, for adding suit and value of card

            for (int suit = 1; suit < 5; suit++)
            {
                for (int value = 0; value < 14; value++)
                {
                    deck[counter] = new PlayingCard(suit, value); // generate card with suit and value, and adding to array
                    counter++;
                }
            }
            return deck;
        }


    }
}
