using DeckGame;

namespace Blackjack;

public class BlackjackGame : Game, IWalkAway
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

    public void WalkAway(Player player)
    {
        throw new NotImplementedException();
    }
    
    
}