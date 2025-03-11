using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(string prompt, string response, string tags)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        _entries.Add(new Entry(date, prompt, response, tags));
    }

    // Display all journal entries
    public void Display()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save journal entries to a file (JSON format)
    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load journal entries from a file (JSON format)
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            Console.WriteLine($"Journal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // Search journal entries by keyword (in prompt, response, or tags)
    public void SearchEntries(string keyword)
    {
        Console.WriteLine($"\nSearch Results for: {keyword}");
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry.Prompt.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry.Response.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry.Tags.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching entries found.");
        }
    }
}