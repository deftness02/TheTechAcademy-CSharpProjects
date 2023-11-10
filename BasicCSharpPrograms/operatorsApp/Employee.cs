namespace operatorsApp;

public class Employee<T>
{
    // Set properties for Employee
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public List<T> Things { get; set; }
    
    // Overload the "==" and "!=" operators so it checks if two Employee objects are equal by comparing their Id property.
    public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
    {
        return employee1.Id == employee2.Id;
    }
    
    public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
    {
        return employee1.Id != employee2.Id;
    }
}