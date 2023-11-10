using DeckGame;
using Blackjack;

Game game = new BlackjackGame();
game.Players = new List<Player>();
var player = new Player() { Name = "Jesse" };
game += player;
game -= player;


var deck = new Deck();
Deck.Shuffle(deck, 3);

foreach (var card in deck.Cards)
{
    Console.WriteLine(card.Value + " of " + card.Suit);
}

Console.WriteLine(deck.Cards.Count);
Console.ReadLine();