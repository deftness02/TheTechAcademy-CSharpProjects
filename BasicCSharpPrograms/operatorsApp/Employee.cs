namespace operatorsApp;

public class Employee
{
    // Set properties for Employee
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    
    // Overload the "==" and "!=" operators so it checks if two Employee objects are equal by comparing their Id property.
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Id == employee2.Id;
    }
    
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.Id != employee2.Id;
    }
}