using System;

class Program
{
    static void Main(string[] args)
    {
      // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        // Convert string input to an integer
        int gradePercentage = int.Parse(input);
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the grade sign (excluding A+ and F+/F- cases)
        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptional cases
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+
        }
        if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        // Print the final letter grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the student passed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You'll get it next time.");
        }
    }
}