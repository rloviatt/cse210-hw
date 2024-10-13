using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Journal class
        Journal journal = new Journal();

        string choice = "0";

        while (choice != "5")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                journal.ReadEntriesFromFile();
            }
            else if (choice == "4")
            {
                journal.WriteEntriesToFile();
            }
            else if (choice == "5")
            {
                choice = "5";
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}