using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int totalPoints = 0;

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;
        if (goalType == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (goalType == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (goalType == "3")
        {
            Console.Write("Enter times to complete: ");
            int timesToComplete = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, timesToComplete, bonusPoints);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        goals.Add(newGoal);
        Console.Clear();
        Console.WriteLine("Goal created successfully!");
    }

    private static void ListGoals()
    {
        Console.Clear();
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }

    private static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.SaveGoal());
            }
        }
    }

    private static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                totalPoints = int.Parse(reader.ReadLine());
                string fileContent = reader.ReadToEnd();
                string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    try
                    {
                        string[] parts = line.Split(',');

                        string goalType = parts[0].Split(':')[1];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        string status = parts[4].Trim(); // Ensure status is treated as a string and trim any whitespace

                        Goal loadedGoal;
                        if (goalType == "Goal")
                        {
                            loadedGoal = new SimpleGoal(name, description, points);
                        }
                        else if (goalType == "EternalGoal")
                        {
                            loadedGoal = new EternalGoal(name, description, points);
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            int timesCompleted = int.Parse(parts[5]);
                            int timesToComplete = int.Parse(parts[6]);
                            int bonusPoints = int.Parse(parts[7]);
                            loadedGoal = new ChecklistGoal(name, description, points, timesToComplete, bonusPoints);
                            // Set the times completed
                            for (int i = 0; i < timesCompleted; i++)
                            {
                                loadedGoal.RecordEvent();
                            }
                        }
                        else
                        {
                            continue;
                        }

                        // Directly set the completion status
                        loadedGoal.CompletionStatus = status;
                        goals.Add(loadedGoal);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error loading goal: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error loading goal: {ex.Message}");
                    }
                }
            }
        }
    }

    private static void RecordEvent()
    {
        Console.Write("Enter the name of the goal to record: ");
        string name = Console.ReadLine();
        Goal goal = goals.Find(g => g.Name == name);
        if (goal != null)
        {
            goal.RecordEvent();
            totalPoints += goal.Points;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }
}