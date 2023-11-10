namespace DeckGame;

public struct Card
{
    public Suit Suit { get; set; }
    public string Face { get; set; }
}

public enum Suit
{
    Clubs,
    Hearts,
    Diamonds,
    Spades
}

public enum Face
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}