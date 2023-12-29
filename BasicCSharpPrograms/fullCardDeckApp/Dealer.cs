using CardGame;

namespace Blackjack;

public class Dealer
{
    public string Name { get; set; }
    public Deck Deck { get; set; }
    public int Balance { get; set; }

    public void Deal(List<Card> Hand)
    {
        var firstCard = Deck.Cards.First();
        Hand.Add(firstCard);
        Console.WriteLine(firstCard + "\n");
        Deck.Cards.RemoveAt(0);
    }
}