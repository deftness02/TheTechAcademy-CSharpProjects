namespace employeeAbstractApp;

public abstract class Person
{
    // Set properties for the Person class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    // Create a virtual method for the Person class to state their first and last name
    public virtual void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}