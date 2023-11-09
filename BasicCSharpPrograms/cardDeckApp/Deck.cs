namespace DeckGame;

public class Deck
{
    public Deck()
    {
        Cards = new List<Card>();
        List<string> suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
        List<string> faces = new List<string>()
        {
            "Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Jack", "Queen", "King"
        };

        foreach (var face in faces)
        {
            foreach (var suit in suits)
            {
                Card card = new Card();
                card.Suit = suit;
                card.Value = face;
                Cards.Add(card);
            }
        }
        
    }
    public List<Card> Cards { get; set; }
    
    public static Deck Shuffle(Deck deck)
    {
        Random random = new Random();
        int n = deck.Cards.Count;
        
        while (n > 1)
        {
            n--;
            var k = random.Next(n + 1);
            Card card = deck.Cards[k];
            deck.Cards[k] = deck.Cards[n];
            deck.Cards[n] = card;
        }

        return deck;
    }

    public static Deck Shuffle(Deck deck, int times)
    {
        for (int i = 0; i < times; i++)
        {
            deck = Shuffle(deck);
        }
        
        return deck;
    }
}