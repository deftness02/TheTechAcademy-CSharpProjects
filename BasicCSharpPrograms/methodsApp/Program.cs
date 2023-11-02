// Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
// In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen.
// Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
// In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
// Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.
// In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.

using methodsApp;

Console.WriteLine("Please enter a number to do math operations on.");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a second number to do math operations on.");
var num2 = Convert.ToInt32(Console.ReadLine());

Maths maths = new Maths();
var rando = maths.GetRandomNumber(num1, num2);
Console.WriteLine("Here's a random number: " + rando);
Console.ReadLine();

Console.WriteLine("Please enter a decimal number to do math operations on.");
var num3 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Please enter a second decimal number to do math operations on.");
var num4 = Convert.ToDecimal(Console.ReadLine());

var rando2 = maths.GetRandomNumber(num3, num4);
Console.WriteLine("Here's a random number: " + rando2);
Console.ReadLine();

Console.WriteLine("Please enter a string number to do math operations on.");
var num5 = Console.ReadLine();

if (!int.TryParse(num5, out int result))
{
    Console.WriteLine("Please enter a valid integer.");
    num5 = Console.ReadLine();
}

Console.WriteLine("Please enter a second string number to do math operations on.");
var num6 = Console.ReadLine();

if (!int.TryParse(num6, out int result2))
{
    Console.WriteLine("Please enter a valid integer.");
    num6 = Console.ReadLine();
}

var rando3 = maths.GetRandomNumber(num5, num6);
Console.WriteLine("Here's a random number: " + rando3);
Console.ReadLine();