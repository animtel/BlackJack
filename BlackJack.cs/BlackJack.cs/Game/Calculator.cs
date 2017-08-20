using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.cs.Interfaces;

namespace BlackJack.cs.Game
{
    class Calculator : ICalculater
    {
        // Compare the player & the dealer
        public void CalculateWinner(Player player, Player dealer)
        {
            // Player wins if... 
            if (dealer.points > 21 || player.cardsInHand == 5 && dealer.cardsInHand != 5)
            {
                Console.WriteLine("{0} Wins!", player.name);
            }

            // The game ends in a draw if... 
            else if (dealer.points == player.points)
            {
                Console.WriteLine("Draw!");
            }
            // The dealer has won
            else if (dealer.points == 21 && player.points != 21 || player.cardsInHand < 5)
            {
                Console.WriteLine("{0} wins", dealer.points);
            }
            else if (player.cardsInHand == 5 && dealer.cardsInHand == 5)
            {
                if (player.points > dealer.points)
                {
                    Console.WriteLine("{0} wins! 5 card trick: higher than dealers. ", player.name);
                }

                else if (player.points == dealer.points)
                {
                    Console.WriteLine("It's a draw! 5 card trick: same! ");
                }

                Console.WriteLine("{0} wins! 5 card trick: less than dealers. ", dealer.name);
            }
        }
    }
}
