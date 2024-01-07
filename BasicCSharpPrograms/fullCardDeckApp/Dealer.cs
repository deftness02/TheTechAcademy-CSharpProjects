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
        
        var cardLog = string.Format(firstCard.ToString() + "\n");
        
        Console.WriteLine(firstCard + "\n");
        using (StreamWriter file = new StreamWriter("logFile.txt", true))
        {
            file.WriteLine(DateTime.Now);
            file.WriteLine(cardLog);
        }
        Deck.Cards.RemoveAt(0);
    }
}