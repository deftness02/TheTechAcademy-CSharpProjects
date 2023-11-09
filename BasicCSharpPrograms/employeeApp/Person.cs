namespace employeeApp;

public class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    // State the entity's name in the console
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}