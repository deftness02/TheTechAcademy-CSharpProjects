namespace CardGame;

public class Deck
{
    public Deck()
    {
        Cards = new List<Card>();
        
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                var card = new Card();
                card.Face = (Face)i;
                card.Suit = (Suit)j;
                Cards.Add(card);
            }
        }
        
    }
    public List<Card> Cards { get; set; }
    
    public static Deck Shuffle(Deck deck)
    {
        var random = new Random();
        var n = deck.Cards.Count;
        
        while (n > 1)
        {
            n--;
            var k = random.Next(n + 1);
            var card = deck.Cards[k];
            deck.Cards[k] = deck.Cards[n];
            deck.Cards[n] = card;
        }

        return deck;
    }

    public static Deck Shuffle(Deck deck, int times)
    {
        for (var i = 0; i < times; i++)
        {
            deck = Shuffle(deck);
        }
        
        return deck;
    }
}