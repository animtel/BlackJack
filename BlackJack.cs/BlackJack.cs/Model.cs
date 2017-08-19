using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.cs.Interfaces;
using BlackJack.cs.Game;

namespace BlackJack.cs
{
    class Model
    {
        Desk _desk = new Desk();
        Output _output = new Output();
        Check _check = new Check();
        Calculate _calc = new Calculate();

        public void Play()
        {
            
            string _playAgain = "Undefined";
            do
            {
                // Generate the deck of cards & shuffle it
                PlayingCard[] deck = _desk.GenerateDeck();
                //GenerateDeck(deck);
                
                _desk.ShuffleDeck(ref deck);

                // Create the two player objects
                Player player = new Player();
                Console.Write("Please enter your name: ");
                player.name = Console.ReadLine();

                Player dealer = new Player();
                Console.Write("Please enter a name for the dealer: ");
                dealer.name = Console.ReadLine();

                // Draw the first two cards for the Player
                _output.DrawCard(deck, ref player);
                _output.DrawCard(deck, ref player);


                _check.CheckAces(ref player); // Call checkAces to see if we can stop player going bust
                _output.OutputHand(player);
                _check.CheckPoints(player); // Output the player's point total
                bool alive = true;

                string choice = "Undefined";

                while (alive == true && choice != "STICK")
                {
                    Console.Write("Hit or Stick? ");
                    choice = Console.ReadLine().ToUpper();
                    if (choice == "HIT") // If the user asks to hit then...
                    {
                        _output.DrawCard(deck, ref player);

                        // If player still has a valid point total, alive will remain true
                        // If the player is now bust, alive will become false and the loop will exit
                        _check.CheckAces(ref player); // Call checkAces to see if we can stop player going bust
                        _output.OutputHand(player);
                        alive = _check.CheckPoints(player);
                    }
                }
                // If the player isn't bust, it's time for the dealer's turn
                if (alive == true)
                {
                    bool dealerAlive = true;

                    Console.WriteLine();
                    Console.WriteLine("*** Dealer's Turn ***");
                    _output.DrawCard(deck, ref dealer);
                    _output.DrawCard(deck, ref dealer);

                    _check.CheckAces(ref dealer); // Call checkAces to see if we can stop dealer going bust
                    _output.OutputHand(dealer);
                    _check.CheckPoints(dealer);

                    while (dealerAlive == true)
                    {
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();

                        // Draw the dealer's next card and check if they are still alive
                        _output.DrawCard(deck, ref dealer);

                        _check.CheckAces(ref dealer); // Call checkAces to see if we can stop dealer going bust
                        _output.OutputHand(dealer);
                        dealerAlive = _check.CheckPoints(dealer);
                    }
                }

                // Calculate & output the winner
                _calc.CalculateWinner(player, dealer);

                Console.Write("Do you want to play again? Y/N ");
                _playAgain = Console.ReadLine().ToUpper();
            } while (_playAgain == "Y");
        }
    }
}
