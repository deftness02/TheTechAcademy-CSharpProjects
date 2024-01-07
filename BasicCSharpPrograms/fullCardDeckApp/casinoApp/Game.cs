using CardGame;

namespace Casino;

public abstract class Game
{
    private List<Player> _players = new List<Player>();
    // Set properties for base game
    public List<Player> Players { get => _players; set => _players = value; }
    private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
    
    public string Name { get; set; }
    public string Dealer { get; set; }
    public Dictionary<Player, int> Bets { get => _bets; set => _bets = value; }

    // Set base method for play to be overridden by each game type
    public abstract void Play();
    
    public virtual void ListPlayers()
    {
        foreach (var player in Players)
        {
            Console.WriteLine(player.Name);
        }
    }
}