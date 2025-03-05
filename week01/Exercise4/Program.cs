using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        
        // Get user input until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int input = -1;
        
        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            
            if (input != 0)  // Do not add 0 to the list
            {
                numbers.Add(input);
            }
        }
        
        // Calculate sum, average, and maximum number
        int sum = 0;
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        
        double average = (double)sum / numbers.Count;
        
        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch challenge: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // Stretch challenge: Sort the numbers and display the sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}