namespace employeeAbstractApp;

public class Employee : Person
{
    // Override the SayName method with the Employee class
    public override void SayName()
    {
        Console.WriteLine("Employee Information");
        base.SayName();
    }
}