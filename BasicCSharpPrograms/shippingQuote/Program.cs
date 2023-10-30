// Define the variables
var shippingQuote = "Welcome to Package Express. Please follow the instructions below.";
var weight = "Please enter the package weight in pounds (lbs), rounded up to the nearest whole number.";
var weightLimit = "Package too heavy to be shipped via Package Express. Have a good day.";
var dimensionsWidth = "Please enter the package width in inches.";
var dimensionsHeight = "Please enter the package height in inches.";
var dimensionsLength = "Please enter the package length in inches.";
var dimensionsLimit = "Package too big to be shipped via Package Express.";
var total = "Your estimated total for shipping this package is: ";
var exit = "Press any key to exit the program...";

// Define the exit behavior
void exitApp(string errorMsg)
{
    Console.WriteLine(errorMsg);
    Console.WriteLine();
    Console.WriteLine(exit);
    Console.ReadKey(true);
    Environment.Exit(0);
}

// Start the quote application
Console.WriteLine(shippingQuote);
Console.WriteLine();
Console.WriteLine("Press any key to start the quote process...");
Console.WriteLine();
Console.ReadKey(true);

// Prompt the user for the weight of the package
Console.WriteLine(weight);
var packageWeight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (packageWeight > 50)
    exitApp(weightLimit);

// Prompt the user for the dimensions of the package
Console.WriteLine(dimensionsWidth);
var packageWidth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(dimensionsHeight);
var packageHeight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(dimensionsLength);
var packageLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Check the dimensions of the package
if (packageWidth + packageHeight + packageLength > 50)
    exitApp(dimensionsLimit);

// Come up with the final quote based on weight and dimensions
var quotePrice = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

Console.WriteLine(total + "$" + quotePrice);
Console.WriteLine();

// Exit the application
Console.WriteLine(exit);
Console.ReadKey(true);
Environment.Exit(0);