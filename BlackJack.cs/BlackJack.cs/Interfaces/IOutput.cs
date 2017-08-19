using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Interfaces
{
    interface IOutput
    {
        void OutputCardSymbol(PlayingCard card);
        void OutputHand(Player player);
        void DrawCard(PlayingCard[] deck, ref Player player);
    }
}
