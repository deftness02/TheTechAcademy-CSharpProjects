// Create an enum for the days of the week.


// Prompt the user to enter the current day of the week.
Console.WriteLine("Please enter the current day of the week.");
Console.WriteLine("Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday");

// Assign the value to a variable of that enum data type you just created.
var userInput = Console.ReadLine();

// Use try and catch to validate the user input against expected values.
try
{
    // Check for null or empty string.
    if (!string.IsNullOrEmpty(userInput))
    {
        var day = Enum.Parse(typeof(DayOfWeek), userInput);
        Console.WriteLine("You entered " + day + ".");
        Console.ReadLine();
    }
}
catch (Exception)
{
    Console.WriteLine("Please enter an actual day of the week. Now is not the time for nonsense.");
    Console.ReadLine();
}

