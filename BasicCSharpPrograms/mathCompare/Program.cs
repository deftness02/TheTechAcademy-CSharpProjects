using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathCompare
{
    internal class Program
    {
        static void Main()
        {
            // Set variables
            var incomeProgram = "Anonymous Income Comparison Program";
            var person1 = "Person 1";
            var person2 = "Person 2";
            var hourlyRate = "Hourly Rate?";
            var hoursWorked = "Hours worked per week?";
            var person1Total = "Annual salary of Person 1:";
            var person2Total = "Annual salary of Person 2:";
            var person1Compare = "Does Person 1 make more money than Person 2?";
            var person2Compare = "Does Person 2 make more money than Person 1?";

            // Identify the report
            Console.WriteLine(incomeProgram);

            // Ask about Person 1
            Console.WriteLine(person1);

            Console.WriteLine(hourlyRate);
            var person1Rate = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(hoursWorked);
            var person1Hours = Console.ReadLine();
            Console.WriteLine();

            // Ask about Person 2
            Console.WriteLine(person2);

            Console.WriteLine(hourlyRate);
            var person2Rate = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(hoursWorked);
            var person2Hours = Console.ReadLine();
            Console.WriteLine();

            // List annual salary
            Console.WriteLine(person1Total);
            var person1TotalSalary = Convert.ToInt32(person1Rate) * Convert.ToInt32(person1Hours) * 52;
            Console.WriteLine(person1TotalSalary);
            Console.WriteLine(person2Total);
            var person2TotalSalary = Convert.ToInt32(person2Rate) * Convert.ToInt32(person2Hours) * 52;
            Console.WriteLine(person2TotalSalary);

            // Compare salaries
            Console.WriteLine(person1Compare);
            Console.WriteLine(person1TotalSalary > person2TotalSalary);
            Console.WriteLine(person2Compare);
            Console.WriteLine(person2TotalSalary > person1TotalSalary);
            Console.Read();
        }
    }
}
