namespace cardDeckApp;

public class Game
{
    public List<string> Players { get; set; }
    public string Name { get; set; }
    public string Dealer { get; set; }

    public void ListPlayers()
    {
        foreach (var player in Players)
        {
            Console.WriteLine(player);
        }
    }
}