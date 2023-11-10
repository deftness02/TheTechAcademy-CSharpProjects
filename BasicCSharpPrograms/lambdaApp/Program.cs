using lambdaApp;

// In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
List<Employee> employeeList = new List<Employee>();
employeeList.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" });
employeeList.Add(new Employee() { Id = 2, FirstName = "Joe", LastName = "Jones" });
employeeList.Add(new Employee() { Id = 3, FirstName = "Jane", LastName = "Doe" });
employeeList.Add(new Employee() { Id = 4, FirstName = "John", LastName = "Doe" });
employeeList.Add(new Employee() { Id = 5, FirstName = "Jack", LastName = "Smith" });
employeeList.Add(new Employee() { Id = 6, FirstName = "Jill", LastName = "Smith" });
employeeList.Add(new Employee() { Id = 7, FirstName = "Jill", LastName = "Jones" });
employeeList.Add(new Employee() { Id = 8, FirstName = "Jill", LastName = "Doe" });
employeeList.Add(new Employee() { Id = 9, FirstName = "Jack", LastName = "Jones" });
employeeList.Add(new Employee() { Id = 10, FirstName = "John", LastName = "Jones" });

// Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
List<Employee> joeList = new List<Employee>();
foreach (Employee employee in employeeList)
{
    if (employee.FirstName == "Joe")
    {
        joeList.Add(employee);
    }
}

// Perform the same action again, but this time with a lambda expression.
Console.WriteLine("Joe List:");
foreach (Employee employee in joeList)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName);
}

Console.ReadLine();

// Perform the same action again, but this time with a lambda expression.
List<Employee> joeList2 = employeeList.Where(x => x.FirstName == "Joe").ToList();

foreach (Employee employee in joeList2)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName);
}

Console.ReadLine();

// Using a lambda expression, make a list of all employees with an Id number greater than 5.
List<Employee> idList = employeeList.Where(x => x.Id > 5).ToList();

foreach (Employee employee in idList)
{
    Console.WriteLine(employee.FirstName + " " + employee.LastName + " (" + employee.Id + ")");
}

Console.ReadLine();