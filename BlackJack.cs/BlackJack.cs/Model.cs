using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.cs.Interfaces;

namespace BlackJack.cs
{
    class Model : IDeckModel
    {
        static Player[] players = new Player[5];
        static int point = 0;

        public PlayingCard[] GenerateDeck()
        {
            PlayingCard[] deck = new PlayingCard[52]; // generate array of card
            int counter = 0; // counter each card in array, for adding suit and value of card

            for (int suit = 1; suit < 5; suit++)
            {
                for (int value = 0; value < 14; value++)
                {
                    deck[counter] = new PlayingCard(suit, value); // generate card with suit and value, and adding to array
                    counter++;
                }
            }
            return deck;
        }

        public static void ShuffleDeck(ref PlayingCard[] deck)
        {
            Random rd = new Random();
            PlayingCard temp;
            int num;

            for (int i = 0; i < deck.Length; i++)
            {
                num = rd.Next(0, deck.Length);

                //swap the content deck[i] and deck[num]
                temp = deck[i];
                deck[i] = deck[num];
                deck[num] = temp;
            }
        }

        static void outputCard(PlayingCard card)
        {
            switch (card.Value) // Case statement based on the value of card
            {
                // Case for 1 - "The Ace of ..."
                case 1:
                    Console.WriteLine("The Ace of {0}", card.Suit);
                    break;

                // Case for 11 - "The Jack of ..."
                case 11:
                    Console.WriteLine("The Jack of {0}", card.Suit);
                    break;

                // Case for 12 - "The Queen of ..."
                case 12:
                    Console.WriteLine("The Queen of {0}", card.Suit);
                    break;

                // Case for 13 - "The King of ..."
                case 13:
                    Console.WriteLine("The King of {0}", card.Suit);
                    break;
                // Case for everything else 
                default:
                    Console.WriteLine("The {0} of {1}", card.Value, card.Suit);
                    break;
            }
        }
    }
}
