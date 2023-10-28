using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyReport
{
    internal class Program
    {
        static void Main()
        {
            // Declare variables
            var techAcademy = "The Tech Academy";
            var studentReport = "Student Daily Report";
            var studentName = "What is your name?";
            var studentCourse = "What course are you on?";
            var studentPage = "What page number?";
            var studentHelp = "Do you need help with anything? Please answer \"true\" or \"false\".";
            var studentFeedback = "Were there any positive experiences you'd like to share? Please give specifics.";
            var studentFeedback2 = "Is there any other feedback you'd like to provide? Please be specific.";
            var studentHours = "How many hours did you study today?";
            var studentThanks = "Thank you for your answers. An Instructor will respond to this shortly. Have a great day!";
            
            // Display the text
            Console.WriteLine(techAcademy);
            Console.WriteLine(studentReport);

            // Ask about student's name
            Console.WriteLine(studentName);
            var name = Console.ReadLine();
            Console.WriteLine();

            // Ask about what course the student is on
            Console.WriteLine(studentCourse);
            var course = Console.ReadLine();
            Console.WriteLine();

            // Ask about what page the student is on
            Console.WriteLine(studentPage);
            var page = Console.ReadLine();
            Console.WriteLine();

            // Ask about if the student needs help
            Console.WriteLine(studentHelp);
            var help = Console.ReadLine();
            Console.WriteLine();

            if (help != "true" && help != "false")
            {
                Console.WriteLine("Please enter \"true\" or \"false\".");
                help = Console.ReadLine();
                Console.WriteLine();
            }
            else if (help == "true")
            {
                Console.WriteLine("Please contact an instructor.");
                Console.WriteLine();
            }
            else if (help == "false")
            {
                Console.WriteLine("Keep up the good work!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter \"true\" or \"false\".");
                help = Console.ReadLine();
                Console.WriteLine();
            }

            // Ask about if the student has any positive experiences
            Console.WriteLine(studentFeedback);
            var feedback = Console.ReadLine();
            Console.WriteLine();

            // Ask about if the student has any other feedback
            Console.WriteLine(studentFeedback2);
            var feedback2 = Console.ReadLine();
            Console.WriteLine();

            // Ask about how many hours the student studied
            Console.WriteLine(studentHours);
            var hours = Console.ReadLine();
            Console.WriteLine();

            // Display the text
            Console.WriteLine(studentThanks);
            Console.ReadLine();
        }
    }
}
