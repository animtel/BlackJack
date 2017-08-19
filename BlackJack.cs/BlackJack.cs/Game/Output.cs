using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.cs.Interfaces;

namespace BlackJack.cs.Game
{
    class Output : IOutput
    {
        public int pointer = 0;

        public void OutputCardSymbol(PlayingCard card)
        {
            switch (card.Value) // Case statement based on the value of card
            {
                // Case for 1 - "The Ace of ..."
                case 1:
                    Console.Write("A{0} ", card.Suit);
                    break;

                // Case for 11 - "The Jack of ..."
                case 11:
                    Console.Write("J{0} ", card.Suit);
                    break;

                // Case for 12 - "The Queen of ..."
                case 12:
                    Console.Write("Q{0} ", card.Suit);
                    break;

                // Case for 13 - "The King of ..."
                case 13:
                    Console.Write("K{0} ", card.Suit);
                    break;
                // Case for everything else 
                default:
                    Console.Write("{0}{1} ", card.Value, card.Suit);
                    break;
            }
        }

        // Outputs all of the cards in a player's hand along with their point total
        public void OutputHand(Player player)
        {
            // Print "Current Hand: "
            Console.Write("Current Hand: ");
            // Loop through all cards in hand
            for (int i = 0; i < player.cardsInHand; i++)
            {
                OutputCardSymbol(player.hand[i]);
            }
            Console.WriteLine("Current points: {0}.", player.points);
        }

        public void DrawCard(PlayingCard[] deck, ref Player player)
        {
            PlayingCard nextCard = deck[pointer];

            // Add the next card in the deck to the player's hand
            if (player.cardsInHand < 5)
            {
                player.hand[player.cardsInHand] = nextCard;

                // Increment the number of cards in the player's hand
                player.cardsInHand++;

                // Add the point value of the new card to the player's total
                player.points += nextCard.Points;

                // Output the details of the card
                //outputCard(nextCard);

                // Increment the pointer
                pointer++;
            }
        }
    }
}
