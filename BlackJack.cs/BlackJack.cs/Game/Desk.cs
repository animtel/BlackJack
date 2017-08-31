using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Game
{
    class Desk
    {

        public List<PlayingCard> GenerateDeck()
        {
            List<PlayingCard> deck = new List<PlayingCard>();

            int counter = 0;

            for (int suit = 1; suit < 5; suit++) 
            {
                for (int value = 1; value < 14; value++) 
                {
                    deck.Add(new PlayingCard(suit, value));
                    counter++; 
                }
            }

            return deck; 
        }

        public void ShuffleDeck(ref List<PlayingCard> deck)
        {
            Random rnd = new Random();
            PlayingCard temp; 
            int num; 

            for (int i = 0; i < deck.Count; i++) 
            {
                num = rnd.Next(0, deck.Count);

                temp = deck[i];
                deck[i] = deck[num];
                deck[num] = temp;
            }

            
        }
    }
}
