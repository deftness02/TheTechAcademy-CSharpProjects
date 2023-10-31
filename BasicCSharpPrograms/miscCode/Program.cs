int[] testScores = { 30, 67, 91, 97, 85, 73, 88, 79, 94, 100 };

for (int i = 0; i < testScores.Length; i++)
{
    if (testScores[i] > 85)
    {
        Console.WriteLine("Passing test score: " + testScores[i]);
    }
}

List<int> intScores = new List<int>();
intScores.Add(30);
intScores.Add(67);
intScores.Add(91);
intScores.Add(97);
intScores.Add(85);
intScores.Add(73);
intScores.Add(88);
intScores.Add(79);
intScores.Add(94);
intScores.Add(100);

foreach (int score in intScores)
{
    if (score > 75)
    {
        Console.WriteLine("Passing test score: " + score);
    }
}

Console.ReadLine();

List<string> listStrings = new List<string>() { "Armsman", "Nightshade", "Bonedancer", "Forester", "Healer" };

foreach (var name in listStrings)
{
    if (name.Contains('a'))
        Console.WriteLine(name);
}

Console.ReadLine();

List<int> listInts = new List<int>() { 98, 54, 78, 89, 84, 66, 33, 100, 91 };
List<int> passingInts = new List<int>();

foreach (var score in listInts)
{
    if (score > 85)
    {
        passingInts.Add(score);
    }
}

Console.WriteLine(passingInts.Count);
Console.WriteLine();

foreach (var passing in passingInts)
{
    Console.WriteLine(passing);
}

Console.ReadLine();
