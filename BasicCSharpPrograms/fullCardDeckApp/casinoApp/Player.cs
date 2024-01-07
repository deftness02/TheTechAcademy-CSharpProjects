using CardGame;

namespace Casino;

public class Player
{
    public Player (string name, int startingBalance)
    {
        Name = name;
        Balance = startingBalance;
        Hand = new List<Card>();
    }

    private List<Card> _hand = new List<Card>();
    public List<Card> Hand { get => _hand; set => _hand = value; }
    public int Balance { get; set; }
    public string Name { get; set; }
    public bool IsActivelyPlaying { get; set; }
    public bool Stay { get; set; }

    public bool Bet(int amount)
    {
        if (Balance - amount < 0)
            return false;
        Balance -= amount;
        return true;
    }

    public static Game operator +(Game game, Player player)
    {
        game.Players.Add(player);

        return game;
    }
    
    public static Game operator -(Game game, Player player)
    {
        game.Players.Remove(player);

        return game;
    }
}