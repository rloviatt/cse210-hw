using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<string> _entries = new();

    public void AddEntry()
    {

        Entry newEntry = new Entry();
        string userEntry = newEntry.GetEntryAsString();
        _entries.Add(userEntry);
        
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void WriteEntriesToFile()
    {
        Console.Write("Please enter the name of the file (with .txt extension) or press Enter to use the default (journal.txt): ");
        string fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            fileName = "journal.txt";
        }

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }

        Console.WriteLine($"Entries have been written to {fileName}");
    }

    public void ReadEntriesFromFile()
    {
        Console.Write("WARNING: This will replace all current entries with those saved in the file. Are you sure you wish to continue? (y/N) ");
        string confirmation = Console.ReadLine();

        if (confirmation.ToLower() != "y")
        {
            Console.WriteLine("Operation cancelled.");
            return;
        }

        Console.Write("Enter the name of the file (with .txt extension) or press Enter to use the default (journal.txt): ");
        string fileName = Console.ReadLine();

        // If user just hits enter assign the var fileName to the default.
        if (string.IsNullOrWhiteSpace(fileName))
        {
            fileName = "journal.txt";
        }

        // Make sure that a file with the name specified exists. If not, exit.
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File {fileName} does not exist.");
            return;
        }

        // Since the file does exist clear the entries list in preparation of reading new entries.
        _entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    _entries.Add(line);
                }
            }
        }

        Console.WriteLine($"Entries have been read from {fileName}");
    }
}