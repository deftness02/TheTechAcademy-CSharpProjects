using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insuranceApp
{
    internal class Program
    {
        static void Main()
        {
            // Define the variables
            var insuranceApp = "ACME Car Insurance Qualification Application";
            var minAge = 15;
            var hasDUI = false;
            var maxSpeedTickets = 3;
            var isQualified = false;

            // Start the application process
            Console.WriteLine(insuranceApp);
            Console.WriteLine();
            Console.WriteLine("What is your age?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Have you ever had a DUI? Please answer \"yes\" or \"no\".");
            var dui = Console.ReadLine();

            // Convert the string to a boolean
            if (dui == "yes")
                hasDUI = true;
            else if (dui == "no")
                hasDUI = false;
            else
            {
                Console.WriteLine("Please answer \"yes\" or \"no\".");
                Console.WriteLine();
                var dui2 = Console.ReadLine();

                // Convert the string to a boolean
                if (dui2 == "yes")
                    hasDUI = true;
                else if (dui2 == "no")
                    hasDUI = false;
            }

            Console.WriteLine();
            Console.WriteLine("How many speeding tickets do you have?");
            var speedTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Post application results
            Console.WriteLine("Thank you for your answers. Please wait while we process your application.");
            Console.WriteLine();
            Console.WriteLine("Application Results:");
            Console.WriteLine();
            Console.WriteLine("What is your age? " + age);
            Console.WriteLine("Have you ever had a DUI? " + hasDUI);
            Console.WriteLine("How many speeding tickets do you have? " + speedTickets);
            Console.WriteLine();

            // Determine if the applicant is qualified
            Console.WriteLine("Qualified?");
            if (age > minAge && !hasDUI && speedTickets <= maxSpeedTickets)
                isQualified = true;
            Console.WriteLine(isQualified);
            if (isQualified)
                Console.WriteLine("Congratulations! You are qualified for car insurance!");
            else
                Console.WriteLine("Sorry, you are not qualified for car insurance.");
            Console.ReadLine();
        }
    }
}
