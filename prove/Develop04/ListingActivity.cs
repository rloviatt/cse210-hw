using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _answers = new List<string>();

    public ListingActivity() : base("Listing Activity",
            "Welcome to the Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
            "Well done!! You have completed the Listing Activity.", 0)
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine("---- " + prompt + " ----");
        Console.WriteLine();
    }

    private void AddToAnswers()
    {
        string answer = Console.ReadLine();
        if (!string.IsNullOrEmpty(answer))
        {
            _answers.Add(answer);
        }
    }

    private void DisplayAmountofAnswers()
    {
        Console.WriteLine($"You listed {_answers.Count} items!");
    }

    public void StartListingActivity()
    {
        Console.WriteLine();
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Spinner();
        Console.WriteLine();
        int duration = GetUserDuration();

        DisplayPrompt();
        Console.WriteLine("You may begin in: ");
        Countdown(5);
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            AddToAnswers();
        }

        DisplayAmountofAnswers();
        Console.WriteLine();
        Console.WriteLine(GetEndMessage());
        Spinner();
        Spinner();
    }
}
