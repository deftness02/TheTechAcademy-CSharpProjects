using cardDeckApp;

BlackjackGame game = new BlackjackGame();
game.Dealer = "Angus MacAngus";
game.Name = "Blackjack";
game.Players = new List<string>() { "Joe", "Bob", "Sally" };
game.ListPlayers();
game.Play();
Console.ReadLine();

Deck deck = new Deck();
var timesShuffled = 3;
deck = Deck.Shuffle(deck, timesShuffled);

foreach (var card in deck.Cards)
{
    Console.WriteLine(card.Value + " of " + card.Suit);
}

Console.WriteLine(deck.Cards.Count);
Console.ReadLine();