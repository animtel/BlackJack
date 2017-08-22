using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Game
{
    class Calculator
    {
        // Compare the player & the dealer
        public void CalculateWinner(Player player, Player dealer)
        {
            // Player wins if... 
            if (dealer.Points > 21 || player.CardsInHand == 5 && dealer.CardsInHand != 5)
            {
                Console.WriteLine("{0} Wins!", player.Name);
            }

            // The game ends in a draw if... 
            if (dealer.Points == player.Points)
            {
                Console.WriteLine("Draw!");
            }
            // The dealer has won
            if (dealer.Points == 21 && player.Points != 21 || player.CardsInHand < 5)
            {
                Console.WriteLine("{0} wins", dealer.Points);
            }
            if (player.CardsInHand == 5 && dealer.CardsInHand == 5)
            {
                if (player.Points > dealer.Points)
                {
                    Console.WriteLine("{0} wins! 5 card trick: higher than dealers. ", player.Name);
                }

                else if (player.Points == dealer.Points)
                {
                    Console.WriteLine("It's a draw! 5 card trick: same! ");
                }

                Console.WriteLine("{0} wins! 5 card trick: less than dealers. ", dealer.Name);
            }
        }
    }
}
