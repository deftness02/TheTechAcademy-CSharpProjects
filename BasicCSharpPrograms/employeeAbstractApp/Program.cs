using employeeAbstractApp;

// Instantiate the Employee class and set values for the FirstName and LastName properties
Employee employee = new Employee();
employee.FirstName = "Sample";
employee.LastName = "Student";

// Call the inherited method
employee.SayName();
Console.ReadLine();