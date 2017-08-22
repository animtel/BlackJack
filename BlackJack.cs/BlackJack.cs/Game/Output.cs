using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Game
{
    class Output
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

        public void OutputHand(Player player)
        {
            // Print "Current Hand: "
            Console.Write("Current Hand: ");
            // Loop through all cards in hand
            for (int i = 0; i < player.CardsInHand; i++)
            {
                OutputCardSymbol(player.Hand[i]);
            }
            Console.WriteLine("Current points: {0}.", player.Points);
        }

        public void DrawCard(List<PlayingCard> deck, ref Player player)
        {
            PlayingCard nextCard = deck[pointer];

            if (player.CardsInHand < 5)
            {
                player.Hand[player.CardsInHand] = nextCard;

                player.CardsInHand++;

                player.Points += nextCard.Points;

                pointer++;
            }
        }
    }
}
