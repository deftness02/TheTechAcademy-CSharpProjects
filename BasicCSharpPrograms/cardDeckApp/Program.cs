using DeckGame;
using Blackjack;



var deck = new Deck();
Deck.Shuffle(deck, 3);

foreach (var card in deck.Cards)
{
    Console.WriteLine(card.Value + " of " + card.Suit);
}

Console.WriteLine(deck.Cards.Count);
Console.ReadLine();