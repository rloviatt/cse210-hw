using System;
using System.Collections.Generic;
using System.Net;
public class Entry
{
    public string GetRandomPrompt()
    {
        List<string> prompts = 
        [
            "What was the best part of my day?",
            "How did I make someone smile today?",
            "What is something new I learned today?",
            "What was the most challenging part of my day?",
            "How did I overcome a challenge today?",
            "What made me laugh today?",
            "What is a goal I achieved today?",
            "How did I show kindness to someone today?",
            "What is a new skill I practiced today?" 
        ];

        if (prompts.Count == 0)
        {
            return "No Prompts available.";
        }
        else
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            string selectedPrompt = prompts[index];
            return selectedPrompt;
        }
    }
    public string GetEntryDateTime()
    {
        DateTime entryDateTime = DateTime.Now;
        return entryDateTime.ToShortDateString();
    }
    public (string, string, string) UserResponse()
    {
        string userPrompt = GetRandomPrompt();
        Console.WriteLine($"{userPrompt}");
        string response = Console.ReadLine();
        string date = GetEntryDateTime();
        return (userPrompt, response, date);
    }

    public void DisplayTestEntry()
    {
        var (userPrompt, response, date) = UserResponse();
        Console.WriteLine($"Date: {date} - Prompt: {userPrompt}\n{response}");
    }

    public string GetEntryAsString()
    {
        var (userPrompt, response, date) = UserResponse();
        string entryString = $"Date: {date} - Prompt: {userPrompt}\n{response}";
        return entryString;
    }
}