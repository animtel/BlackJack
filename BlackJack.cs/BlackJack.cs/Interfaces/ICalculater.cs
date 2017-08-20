using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Interfaces
{
    interface ICalculater
    {
        void CalculateWinner(Player player, Player dealer);
    }
}
