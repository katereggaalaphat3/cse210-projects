using System;

class Program
{
    // Display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Square the given number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Display the result
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

    // Main method (entry point of the program)
    static void Main(string[] args)
    {
        DisplayWelcome(); // Call to display welcome message
        string userName = PromptUserName(); // Call to get user name
        int favoriteNumber = PromptUserNumber(); // Call to get favorite number
        int squaredNumber = SquareNumber(favoriteNumber); // Call to square the number
        DisplayResult(userName, squaredNumber); // Display the result
    }
}
