using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Interfaces
{
    interface IDeckModeler
    {
        List<PlayingCard> GenerateDeck();

        void ShuffleDeck(ref List<PlayingCard> deck);
    }
}
