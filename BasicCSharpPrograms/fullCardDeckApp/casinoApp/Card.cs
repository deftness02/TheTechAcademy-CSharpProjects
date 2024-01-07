namespace Casino;

public struct Card
{
    public Suit Suit { get; set; }
    public Face Face { get; set; }
    
    public override string ToString()
    {
        return $"{Face} of {Suit}";
    }
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