using operatorsApp;

// Instantiate two Employee objects and assign values to their properties.
var employee1 = new Employee<string>();
var employee2 = new Employee<int>();

// Instantiate two lists and assign values to them.
var things1 = new List<string>() { "thing1", "thing2", "thing3" };
var things2 = new List<int>() { 1, 2, 3 };

employee1.FirstName = "Donald";
employee1.LastName = "Student";
employee1.Id = 1;

employee2.FirstName = "Donna";
employee2.LastName = "Student";
employee2.Id = 2;

// Compare the two Employee objects using the overloaded "==" operator.
Console.WriteLine(employee1.Id == employee2.Id);
Console.ReadLine();

// Print each thing in the list for each Employee object.
foreach (var thing in things1)
{
    Console.WriteLine(thing);
}
Console.ReadLine();

foreach (var thing in things2)
{
    Console.WriteLine(thing);
}
Console.ReadLine();