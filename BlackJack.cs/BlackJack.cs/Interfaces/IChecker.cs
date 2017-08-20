using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Interfaces
{
    interface IChecker
    {
        bool CheckPoints(Player player);

        void CheckAces(ref Player player);
    }
}
