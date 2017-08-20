using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Interfaces
{
    interface IOutputer
    {
        void OutputCardSymbol(PlayingCard card);
        void OutputHand(Player player);
        void DrawCard(List<PlayingCard> deck, ref Player player);
    }
}
