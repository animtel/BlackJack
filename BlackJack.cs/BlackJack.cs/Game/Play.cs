using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.cs.Game
{
    class Play
    {
        private Desk _desk = new Desk();
        private Output _output = new Output();
        private Check _check = new Check();
        private Calculator _calc = new Calculator();

        public void PlayGame()
        {

            var _playAgain = "Undefined";
            do
            {
                List<PlayingCard> deck = _desk.GenerateDeck();
                

                _desk.ShuffleDeck(ref deck);

                Player player = new Player();
                Console.Write("Please enter your name: ");
                player.Name = Console.ReadLine();

                Player dealer = new Player();
                Console.Write("Please enter a name for the dealer: ");
                dealer.Name = Console.ReadLine();

                _output.DrawCard(deck, ref player);
                _output.DrawCard(deck, ref player);


                _check.CheckAces(ref player);
                _output.OutputHand(player);
                _check.CheckPoints(player); 
                var alive = true;

                var choice = "Undefined";

                while (alive == true && choice != "STICK")
                {
                    Console.Write("Hit or Stick? ");
                    choice = Console.ReadLine().ToUpper();
                    if (choice == "HIT") 
                    {
                        _output.DrawCard(deck, ref player);

                        _check.CheckAces(ref player); 
                        _output.OutputHand(player);
                        alive = _check.CheckPoints(player);
                    }
                }
                if (alive == true)
                {
                    bool dealerAlive = true;

                    Console.WriteLine();
                    Console.WriteLine("*** Dealer's Turn ***");
                    _output.DrawCard(deck, ref dealer);
                    _output.DrawCard(deck, ref dealer);

                    _check.CheckAces(ref dealer); 
                    _output.OutputHand(dealer);
                    _check.CheckPoints(dealer);

                    while (dealerAlive == true)
                    {
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();

                        _output.DrawCard(deck, ref dealer);

                        _check.CheckAces(ref dealer); 
                        _output.OutputHand(dealer);
                        dealerAlive = _check.CheckPoints(dealer);
                    }
                }

                Console.WriteLine(_calc.CalculateWinner(player, dealer));

                Console.Write("Do you want to play again? Y/N ");
                _playAgain = Console.ReadLine().ToUpper();
            } while (_playAgain == "Y");
        }
    }
}
