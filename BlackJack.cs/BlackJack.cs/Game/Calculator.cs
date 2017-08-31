using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Game
{
    class Calculator
    {
        public string CalculateWinner(Player player, Player dealer)
        {
            if (dealer.Points > 21 || player.CardsInHand == 5 && dealer.CardsInHand != 5)
            {
                return $"{player.Name} Wins!";
            }
            if (dealer.Points == player.Points)
            {
                return "Draw!";
            }
            if (dealer.Points == 21 && player.Points != 21 || player.CardsInHand < 5)
            {
                return $"{dealer.Points} wins";
            }
            if (player.CardsInHand == 5 && dealer.CardsInHand == 5)
            {
                if (player.Points > dealer.Points)
                {
                    return $"{player.Name} wins! 5 card trick: higher than dealers. ";
                }

                if (player.Points == dealer.Points)
                {
                    return "It's a draw! 5 card trick: same! ";
                }

                return $"{dealer.Name} wins! 5 card trick: less than dealers. ";
            }
            return "";
        }
    }
}
