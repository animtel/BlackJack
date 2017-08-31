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
            if (player.Points > 21)
            {
                Console.WriteLine("Bust!");
                return false;
            }

            return true;
        }



       
        public void CheckAces(ref Player player)
        {
            bool changed = false; 
            if (player.Points <= 21)
            {
                return;
            }
            for (int i = 0; i < player.CardsInHand; i++)
            {
                if (player.Hand[i].Points == 11 && changed == false)
                {
                    player.Hand[i].Points = 1; 
                    player.Points -= 10; 
                    changed = true;
                }
            }
        }
    }
}
