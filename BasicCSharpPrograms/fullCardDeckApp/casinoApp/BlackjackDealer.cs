using Casino;

namespace CardGame.Blackjack;

public class BlackjackDealer : Dealer
{
    public bool Stay { get; set; }
    public bool IsBusted { get; set; }
    public bool IsStay { get; set; }
    private List<Card> _hand = new List<Card>();
    public List<Card> Hand { get => _hand; set => _hand = value; }
    public int Balance { get; set; }
    
}