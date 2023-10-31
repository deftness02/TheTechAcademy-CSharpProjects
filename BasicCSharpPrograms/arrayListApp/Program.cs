// Define arrays/variables
string[] stringArray = new[] { "Armsman", "Nightshade", "Bonedancer", "Forester", "Healer" };
int[] intArray = new[] { 1, 20, 30, 40, 50 };
var exit = "Press any key to exit the program...";

// Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
// Add in a message that displays when the user selects an index that doesn’t exist.
Console.WriteLine("Please select an index of the string array: ");
int stringIndex = Convert.ToInt32(Console.ReadLine());
var indexExists = false;

do
{
    if (stringIndex > stringArray.Length - 1)
    {
        Console.WriteLine("That index does not exist. Please try again.");
        stringIndex = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("You selected: " + stringArray[stringIndex]);
        indexExists = true;
    }
} 
while (!indexExists);

// Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
// Add in a message that displays when the user selects an index that doesn’t exist.
Console.WriteLine();
Console.WriteLine("Please select an index of the int array: ");
int intIndex = Convert.ToInt32(Console.ReadLine());
var intExists = false;

do
{
    if (intIndex > intArray.Length - 1)
    {
        Console.WriteLine("That index does not exist. Please try again.");
        intIndex = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("You selected: " + intArray[intIndex]);
        intExists = true;
    }
} 
while (!intExists);

// Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
List<string> stringList = new List<string>();
stringList.Add("Armsman");
stringList.Add("Nightshade");
stringList.Add("Bonedancer");
stringList.Add("Forester");
stringList.Add("Healer");

Console.WriteLine();
Console.WriteLine("Please select an index of the string list: ");
int stringListIndex = Convert.ToInt32(Console.ReadLine());
var stringListExists = false;

do
{
    if (stringListIndex > stringList.Count - 1)
    {
        Console.WriteLine("That index does not exist. Please try again.");
        stringListIndex = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("You selected: " + stringList[stringListIndex]);
        stringListExists = true;
    }
}
while (!stringListExists);

// Exit the program
Console.WriteLine(exit);
Console.ReadKey(true);
Environment.Exit(0);