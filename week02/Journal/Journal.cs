using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        _entries.Add(new Entry(date, prompt, response));
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

    // Save journal entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load journal entries from a file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
