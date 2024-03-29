using Casino;
using casinoApp;

namespace CardGame.Blackjack;

public class BlackjackGame : Game, IWalkAway
{
    public BlackjackDealer Dealer { get; set; }
    
    public override void Play()
    {
        // Reset Player(s)
        Dealer = new BlackjackDealer();

        foreach (var player in Players)
        {
            player.Hand = new List<Card>();
            player.Stay = false;
        }
        
        // Reset Dealer
        Dealer.Hand = new List<Card>();
        Dealer.Stay = false;
        Dealer.Deck = new Deck();
        Deck.Shuffle(Dealer.Deck);

        foreach (var player in Players)
        {
            var validBet = false;
            var bet = 0;
            
            while (!validBet)
            {
                validBet = int.TryParse(Console.ReadLine(), out bet);

                if (!validBet)
                    Console.WriteLine("Please enter digits only, no decimals.");
            }
            
            if (bet < 0)
            {
                throw new FraudException("Security! Kick this moron out. He can't even bet right.");
            }
            
            bool successfullyBet = player.Bet(bet);
            
            if (!successfullyBet)
                return;
            
            Bets[player] = bet;
        }

        for (int i = 1; i < 2; i++)
        {
            Console.WriteLine($"Dealing round {i}.");

            foreach (var player in Players)
            {
                Console.Write($"{player.Name}: ");
                Dealer.Deal(player.Hand);
                
                if (i == 1)
                {
                    bool blackJack = BlackjackRules.CheckForBlackJack(player.Hand);

                    if (blackJack)
                    {
                        Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                        
                        player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);

                        Bets.Remove(player);

                        return;
                    }

                }
            }
            
            Console.WriteLine("Dealer: ");
            Dealer.Deal(Dealer.Hand);

            if (i == 1)
            {
                bool blackJack = BlackjackRules.CheckForBlackJack(Dealer.Hand);
                
                if (blackJack)
                {
                    Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                    
                    foreach (KeyValuePair<Player, int> entry in Bets)
                    {
                        Dealer.Balance += entry.Value;
                    }

                    return;
                }
            }
        }

        foreach (Player player in Players)
        {
            while (!player.Stay)
            {
                Console.WriteLine("Your cards are: ");

                foreach (Card card in player.Hand)
                {
                    Console.WriteLine("{0} ", card.ToString());
                }
                
                Console.WriteLine("\n\nHit or Stay?");

                string answer = Console.ReadLine().ToLower();

                if (answer == "stay")
                {
                    player.Stay = true;
                    break;
                }
                if (answer == "hit")
                {
                    Dealer.Deal(player.Hand);
                }
                
                bool busted = BlackjackRules.IsBusted(player.Hand);

                if (busted)
                {
                    Dealer.Balance += Bets[player];
                    Console.WriteLine("{0} busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                    Console.WriteLine("Do you want to play again?");

                    answer = Console.ReadLine().ToLower();

                    if (answer == "yes" || answer == "y")
                    {
                        player.IsActivelyPlaying = true;
                        return;
                    }
                    else
                    {
                        player.IsActivelyPlaying = false;
                        return;
                    }
                }
            }
        }
        
        Dealer.IsBusted = BlackjackRules.IsBusted(Dealer.Hand);
        Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);

        while (!Dealer.Stay && !Dealer.IsBusted)
        {
            Console.WriteLine("Dealer is hitting...");
            
            Dealer.Deal(Dealer.Hand);
            Dealer.IsBusted = BlackjackRules.IsBusted(Dealer.Hand);
            Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
        }

        if (Dealer.Stay)
        {
            Console.WriteLine("Dealer is staying.");
        }

        if (Dealer.IsBusted)
        {
            Console.WriteLine("Dealer busted!");

            foreach (KeyValuePair<Player, int> entry in Bets)
            {
                Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
            }

            return;
        }

        foreach (Player player in Players)
        {
            bool? playerWon = BlackjackRules.CompareHands(player.Hand, Dealer.Hand);

            if (playerWon == null)
            {
                Console.WriteLine("Push! No one wins.");
                player.Balance += Bets[player];
                Bets.Remove(player);
            }
            else if (playerWon == true)
            {
                Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);

                player.Balance += (Bets[player] * 2);
                Dealer.Balance -= Bets[player];
            }
            else
            {
                Console.WriteLine("Dealer wins {0}!", Bets[player]);
                Dealer.Balance += Bets[player];
            }
            
            Console.WriteLine("Play again?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "y")
                player.IsActivelyPlaying = true;
            else
                player.IsActivelyPlaying = false;
        }
    }

    public override void ListPlayers()
    {
        Console.WriteLine("Blackjack Players:");
        base.ListPlayers();
    }

    public void WalkAway(Player player)
    {
        throw new NotImplementedException();
    }
    
    
}