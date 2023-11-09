using DeckGame;

namespace Blackjack;

public class BlackjackGame : Game
{
    public override void Play()
    {
        throw new NotImplementedException();
    }

    public override void ListPlayers()
    {
        Console.WriteLine("Blackjack Players:");
        base.ListPlayers();
    }
}