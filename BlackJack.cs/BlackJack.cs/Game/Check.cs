using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.cs.Interfaces;

namespace BlackJack.cs.Game
{
    class Check : ICheck
    {
        // Check if the player has exceeded 21 points
        // Output the player's point total
        public bool CheckPoints(Player player)
        {
            // Output the player's point total
            //Console.WriteLine("Current Points: {0}", player.points);

            // Check if the player is bust
            if (player.points > 21)
            {
                Console.WriteLine("Bust!");
                return false;
            }

            // Return true if the player is still alive
            return true;
        }

        // Checks if the player has any aces with a point value of 11 (high)
        // If the player is about to go bust, change the ace to a point value of 1 (low)
        // Then update the player's score
        public void CheckAces(ref Player player)
        {
            bool changed = false; // Flags up if we've changed an ace already
            if (player.points > 21)
            {
                for (int i = 0; i < player.cardsInHand; i++)
                {
                    if (player.hand[i].Points == 11 && changed == false) // If it's a high ace
                    {
                        player.hand[i].Points = 1; // Change it to a low ace
                        player.points -= 10; // Take 10 away from player's points
                        changed = true;
                    }
                }
            }

        }
    }
}
