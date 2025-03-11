using System;
using System.Text.Json.Serialization;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Tags { get; set; }  // New property for tags

    // Parameterized constructor
    [JsonConstructor] // This tells the serializer which constructor to use
    public Entry(string date, string prompt, string response, string tags)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Tags = tags;
    }

    // Default constructor (needed for deserialization)
    public Entry() {}

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Tags: {Tags}");
        Console.WriteLine("--------------------------------");
    }
}
