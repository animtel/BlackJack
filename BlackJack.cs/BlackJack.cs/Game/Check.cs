using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Game
{
    class Check
    {
        
        public bool CheckPoints(Player player)
        {
            // Check if the player is bust
            if (player.Points > 21)
            {
                Console.WriteLine("Bust!");
                return false;
            }

            // Return true if the player is still alive
            return true;
        }



       
        public void CheckAces(ref Player player)
        {
            bool changed = false; // Flags up if we've changed an ace already
            if (player.Points <= 21)
            {
                return;
            }
            for (int i = 0; i < player.CardsInHand; i++)
            {
                if (player.Hand[i].Points == 11 && changed == false) // If it's a high ace
                {
                    player.Hand[i].Points = 1; // Change it to a low ace
                    player.Points -= 10; // Take 10 away from player's points
                    changed = true;
                }
            }
        }
    }
}
