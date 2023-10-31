List<int> intList = new List<int>();
intList.Add(4);
intList.Add(51);
intList.Add(23);
intList.Add(89);
intList.Add(12);
intList.Add(34);
var errorFound = false;

// Prompt the user for a number to divide by.
Console.WriteLine("Enter a number to divide a bunch of numbers by.");

// Catch exceptions
// Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
do
{
    try
    {
        int divisor = Convert.ToInt32(Console.ReadLine());
        
        // Divide each number and display the result
        for (int i = 0; i < intList.Count; i++)
        {
            intList[i] /= divisor;
            Console.WriteLine(intList[i]);
            errorFound = false;
        }
    }
    catch (DivideByZeroException ex)
    {
        errorFound = true;
        Console.WriteLine("You cannot divide by zero.");
        Console.ReadLine();
    }
    catch (FormatException ex)
    {
        errorFound = true;
        Console.WriteLine("Please type a whole number.");
    }
    catch (Exception ex)
    {
        errorFound = true;
        Console.WriteLine(ex.Message);
    }
} 
while (errorFound);

Console.WriteLine("All done!");
Console.ReadLine();