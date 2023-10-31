var guessGame = "Amazing Number Guesstimation Trivia Challenge Supreme";
var guessRules = "The rules are quite simple. Guess what number I'm thinking of and you win!";
var exit = "Press any key to exit the program...";
var number = new Random().Next(1, 100); // Randomly select number each time
var correctGuess = false;

// Begin the program
Console.WriteLine(guessGame);
Console.WriteLine(guessRules);
Console.WriteLine();
Console.WriteLine("Press any key to start the game...");
Console.WriteLine();
Console.ReadKey(true);

// Prompt the user for a guess
Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");
Console.WriteLine();
var guess = Convert.ToInt32(Console.ReadLine());
var guessWrong = "You guessed " + guess + ". That is incorrect. Please try again.";
var guessRight = "You guessed " + guess + ". That is correct! You win!";

// Repeat until number is guessed
do
{
    // Check the user's guess
    if (guess < number)
    {
        Console.WriteLine(guessWrong);
        Console.WriteLine();
        Console.WriteLine("Please guess again.");
        Console.WriteLine();
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else if (guess > number)
    {
        Console.WriteLine(guessWrong);
        Console.WriteLine();
        Console.WriteLine("Please guess again.");
        Console.WriteLine();
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine(guessRight);
        correctGuess = true;
    }
} 
while (!correctGuess);

// Exit the program
Console.WriteLine(exit);
Console.ReadKey(true);
Environment.Exit(0);