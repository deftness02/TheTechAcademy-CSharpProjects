using CardGame;

namespace Blackjack;

public class BlackjackDealer : Dealer
{
    public bool Stay { get; set; }
    public bool IsBusted { get; set; }
    public bool IsStay { get; set; }
    public List<Card> Hand { get; set; }
    public int Balance { get; set; }
    
}