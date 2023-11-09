namespace DeckGame;

public abstract class Game
{
    // Set properties for base game
    public List<string> Players { get; set; }
    public string Name { get; set; }
    public string Dealer { get; set; }

    // Set base method for play to be overridden by each game type
    public abstract void Play();
    
    public virtual void ListPlayers()
    {
        foreach (var player in Players)
        {
            Console.WriteLine(player);
        }
    }
}