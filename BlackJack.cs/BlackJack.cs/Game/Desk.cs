using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.cs.Interfaces;

namespace BlackJack.cs.Game
{
    class Desk : IDeckModeler
    {

        /// <summary>
        /// Generates the deck of 52 cards
        /// </summary>
        public List<PlayingCard> GenerateDeck()
        {
            List<PlayingCard> deck = new List<PlayingCard>();
            int counter = 0; // Tells us where to save the next value into the array

            // Nested for loop to generate all 52 cards - 4 possible suits with 13 possible values each
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

        // Procedure to shuffle the deck of cards
        public void ShuffleDeck(ref List<PlayingCard> deck)
        {
            Random rnd = new Random(); // Creates new Random object
            PlayingCard temp; // Creates a variable for temporarily storing a PlayingCard
            int num; // Creates an integer variable for storing the randomly generated numbers

            for (int i = 0; i < deck.Count; i++) // Loop through each index in the array
            {
                num = rnd.Next(0, deck.Count); // Generate random num between 0 & 51

                // Swap the contents of deck[i] and deck[num]
                temp = deck[i];
                deck[i] = deck[num];
                deck[num] = temp;
            }

            // As deck is passed by reference, we do not need to return it to the main program
            // The changes will have automatically been applied to the deck in the main program
        }
    }
}
