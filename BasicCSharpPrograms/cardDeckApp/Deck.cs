namespace DeckGame;

public class Deck
{
    public Deck()
    {
        Cards = new List<Card>();
        var suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
        var faces = new List<string>()
        {
            "Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Jack", "Queen", "King"
        };

        foreach (var face in faces)
        {
            foreach (var suit in suits)
            {
                var card = new Card();
                card.Suit = suit;
                card.Value = face;
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