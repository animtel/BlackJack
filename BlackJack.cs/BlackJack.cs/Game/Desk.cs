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

            for (int suit = 1; suit < 5; suit++) // Loop through the 4 possible suits
            {
                for (int value = 1; value < 14; value++) // Loop through the 13 possible values
                {
                    deck.Add(new PlayingCard(suit, value));
                    counter++; // Increment the counter
                }
            }

            return deck; // Returns the completed deck
        }

        public void ShuffleDeck(ref List<PlayingCard> deck)
        {
            Random rnd = new Random(); // Creates new Random object
            PlayingCard temp; // Creates a variable for temporarily storing a PlayingCard
            int num; // Creates an integer variable for storing the randomly generated numbers

            for (int i = 0; i < deck.Count; i++) // Loop through each index in the array
            {
                num = rnd.Next(0, deck.Count); // Generate random num between 0 & 51

                temp = deck[i];
                deck[i] = deck[num];
                deck[num] = temp;
            }

            
        }
    }
}
