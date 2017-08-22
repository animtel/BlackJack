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
        
        public PlayingCard(int suit, int value)
        {
            Value = value;
            Suit = SuitCard(suit);
            

            if (Value > 10)
            {
                Points = 10;
            }

            if (Value == 1) // If it's an ace
            {
                Points = 11; // Set the points to 11
            }

            else
            {
                Points = Value;
            }
        }
        public string SuitCard(int suit)
        {
            Array values = Enum.GetValues(typeof(Suits));
            Suits randomSuit = (Suits)values.GetValue(suit);
            return randomSuit.ToString();
        }
        enum Suits
        {
            Q,
            K,
            C,
            B,
            p
        }
    }
}
