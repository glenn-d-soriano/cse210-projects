using System;
using System.Collections.Generic;
using System.IO;
//Save or load journal entries to JSON for storage.
using System.Text.Json;

public class Journal
{
    // List to hold all entries
    private List<Entry> _entries;

    // Constructor to initialize the list
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.ToString());  // Using the ToString() method from Entry class
        }
    }

    // Save journal entries to a file in JSON format using System.Text.Json
    public void SaveToFile(string file)
    {
        try
        {
            string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file, json);
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    // Load journal entries from a JSON file using System.Text.Json
    public void LoadFromFile(string file)
    {
        try
        {
            if (File.Exists(file))
            {
                string json = File.ReadAllText(file);
                _entries = JsonSerializer.Deserialize<List<Entry>>(json);
                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
