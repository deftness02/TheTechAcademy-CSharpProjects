using operatorsApp;

// Instantiate two Employee objects and assign values to their properties.
var employee1 = new Employee();
var employee2 = new Employee();

employee1.FirstName = "Donald";
employee1.LastName = "Student";
employee1.Id = 1;

employee2.FirstName = "Donna";
employee2.LastName = "Student";
employee2.Id = 2;

// Compare the two Employee objects using the overloaded "==" operator.
Console.WriteLine(employee1 == employee2);
Console.ReadLine();