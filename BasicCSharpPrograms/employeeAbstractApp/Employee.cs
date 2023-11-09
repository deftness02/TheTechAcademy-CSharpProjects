namespace employeeAbstractApp;

// Create an Employee class and have it inherit from the Person class and IQuittable interface
public class Employee : Person, IQuittable
{
    // Override the SayName method with the Employee class
    public override void SayName()
    {
        Console.WriteLine("Employee Information");
        base.SayName();
    }
    
    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine("This person has just quit.");
    }
}