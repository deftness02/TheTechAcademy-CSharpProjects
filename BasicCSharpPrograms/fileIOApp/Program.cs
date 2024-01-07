Console.WriteLine("Please enter a number greater than 0.");

// Check the player's response and parse.
int number;
var isNumber = false;
Console.ReadLine();

// Check to make sure a number is provided
while (!isNumber)
{
    try
    {
        if (Console.ReadLine() != null) number = int.Parse(Console.ReadLine());
        isNumber = true;
    }
    catch
    {
        Console.WriteLine("Please enter a number greater than 0.");
    }
}

// Log the value entered
using StreamWriter file = new StreamWriter("logFile.txt", true);
file.WriteLine(Console.ReadLine());

// Repeat back the contents logged
File.WriteAllText("logFile.txt", Console.ReadLine());