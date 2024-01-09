using Casino;
using CardGame.Blackjack;
using casinoApp;

const string casinoName = "Grand Budapest Hotel Casino";

// Start the app with introductions and information gathering
Console.WriteLine(casinoName);
Console.WriteLine("----------------------");
Console.WriteLine();
Console.WriteLine("Welcome to the Grand Budapest Hotel Casino. What is your name?");

string playerName = Console.ReadLine() ?? string.Empty;

if (playerName.ToLower() == "admin")
{
    List<ExceptionEntity> Exceptions = ExceptionEntity.ReadExceptions();
    
    foreach (var exception in Exceptions)
    {
        Console.WriteLine(exception.Id + " | " + exception.ExceptionType + " | " + exception.ExceptionMessage + " | " + exception.TimeStamp);
    }

    Console.ReadLine();
    return;
}

var playerId = Guid.NewGuid();

Console.WriteLine($"Hello, {playerName}! How much money did you bring today?");

// Check the player's response. If the entry has a "$" at the start, remove it.
// If the entry is not an integer, ask again.
// If the entry is null, set it to 0.
var bank = 0;
var hasMoney = false;

while (!hasMoney)
{
    Console.WriteLine("And how much money did you bring today?");
        
    hasMoney = int.TryParse(Console.ReadLine(), out bank);
    if (!hasMoney)
        Console.WriteLine("Please enter digits only.");
}

Console.WriteLine($"You brought ${bank} with you today. Good luck!");
Console.WriteLine();

Console.WriteLine("Would you like to join a game of Blackjack now?");

// Check the player's response. If the entry is not "yes" or "no", ask again.
var answer = Console.ReadLine()!.ToLower();
var isReady = false;

while (!isReady)
{
    if (answer == "yes" || answer == "y")
    {
        isReady = true;
    }
    else if (answer == "no" || answer == "n")
    {
        Console.WriteLine("Okay, maybe another time. Have a good day!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Please enter \"yes\" or \"no\".");
        answer = Console.ReadLine()!.ToLower();
    }
}

Console.WriteLine("Great! Let's get started.");
Console.ReadLine();

// Get an instance of the player and game running
Player player = new Player(playerName, bank);
player.Id = playerId;

// Log the player's ID to a file
using (StreamWriter file = new StreamWriter("logFile.txt", true))
{
    file.WriteLine("Player ID: " + player.Id);
}

Game game = new BlackjackGame();
game += player;
player.IsActivelyPlaying = true;

// Logic for when they are playing the game
while (player.IsActivelyPlaying && player.Balance > 0)
{
    try
    {
        game.Play();
    }
    catch (FraudException ex)
    {
        Console.WriteLine("Nice try. You think I was born yesterday, squirt? You're outta here!");
        Game.UpdateDbWithException(ex);
        Console.ReadLine();
        return;
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred. Please try again.");
        Game.UpdateDbWithException(ex);
        Console.ReadLine();
        return;
    }
}

// Logic for when they quit the game
game -= player;
player.IsActivelyPlaying = false;

Console.WriteLine("Thank you for playing!");
Console.ReadLine();
Environment.Exit(0);