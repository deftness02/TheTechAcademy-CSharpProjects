using DeckGame;
using Blackjack;

var game = new BlackjackGame();
game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
game.ListPlayers();
Console.ReadLine();

var deck = new Deck();
Deck.Shuffle(deck, 3);

foreach (var card in deck.Cards)
{
    Console.WriteLine(card.Value + " of " + card.Suit);
}

Console.WriteLine(deck.Cards.Count);
Console.ReadLine();