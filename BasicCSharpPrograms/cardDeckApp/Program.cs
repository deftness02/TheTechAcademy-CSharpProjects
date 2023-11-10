using DeckGame;
using Blackjack;

var deck = new Deck();
List<Card> newList = deck.Cards.Where(x => x.Face == Face.Ace).ToList();

foreach (var card in newList)
{
    Console.WriteLine(card.Face + " of " + card.Suit);
}

// var count = deck.Cards.Count(x => x.Face == Face.Ace);


// Deck.Shuffle(deck, 3);
//
// foreach (var card in deck.Cards)
// {
//     Console.WriteLine(card.Face + " of " + card.Suit);
// }
//
// Console.WriteLine(deck.Cards.Count);
Console.ReadLine();