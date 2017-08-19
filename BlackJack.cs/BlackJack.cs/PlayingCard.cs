using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs
{
    class PlayingCard
    {
        public string Suit { get; set; }
        public int Value { get; set; }
        public int Points { get; set; }

        public PlayingCard(int s, int v)
        {
            Value = v;
            switch (s)
            {
                case 1:
                    Suit = "K";
                    break;
                case 2:
                    Suit = "C";
                    break;
                case 3:
                    Suit = "B";
                    break;
                case 4:
                    Suit = "P";
                    break;
            }

            if (Value > 10)
            {
                Points = 10;
            }
            else if (Value == 1) // If it's an ace
            {
                Points = 11; // Set the points to 11
            }
            else
            {
                Points = Value;
            }
        }
    }
}
