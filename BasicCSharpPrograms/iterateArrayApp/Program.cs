using System.Text;

// A one-dimensional array of strings.
string[] stringArray = { "Albion", "Hibernia", "Midgard", "Neutral" };

// Ask the user to input some text.
Console.WriteLine("Please input some text.");
var appendText = Console.ReadLine();
Console.WriteLine();

StringBuilder sb = new StringBuilder();

// A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
for (int i = 0; i < stringArray.Length; i++)
{
    sb.Append(stringArray[i] + appendText);
    stringArray[i] = sb.ToString();
    sb.Clear();
}

// Then create a second loop that prints off each string in the array one at a time.
foreach (string realm in stringArray)
{
    Console.WriteLine(realm);
}

Console.ReadLine();

// A list of strings where each item in the list is unique.
string[] daocClasses = { "Armsman", "Cabalist", "Sorcerer", "Wizard", "Necromancer", "Reaver", "Minstrel", "Paladin", "Cleric", "Friar", "Theurgist", "Mercenary", "Scout", "Infiltrator", "Hunter", "Bard", "Healer", "Mauler", "Berserker", "Savage", "Heretic", "Blademaster", "Champion", "Druid", "Warden", "Animist", "Bainshee", "Valewalker", "Eldritch", "Enchanter", "Hero", "Shadowblade", "Shaman", "Skald", "Spiritmaster", "Thane", "Valkyrie", "Warlock" };
var classExists = false;

// Ask the user to input text to search for in the list.
Console.WriteLine("Please input a Dark Age of Camelot character class name to search for in the list.");
Console.WriteLine();
var classEntry = Console.ReadLine();

do
{
    // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
    for (int i = 0; i < daocClasses.Length && !classExists; i++)
    {
        if (daocClasses[i].Contains(classEntry))
        {
            Console.WriteLine("Index: " + i);
            classExists = true;
        }
    }
    
    // Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
    if (!classExists)
    {
        Console.WriteLine("That class is not on the list. Please try again.");
        classEntry = Console.ReadLine();
    }
} 
// Add code that stops the loop from executing once a match has been found.
while (!classExists);