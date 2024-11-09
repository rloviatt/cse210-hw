using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "Welcome to the Reflection Activity", 
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 
               "Well Done!! You have completed the Reflecting Activity.", 0)
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine("---- " + prompt + " ----");
        Console.WriteLine();
    }

    private void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write(question + " ");
        Spinner();
        Spinner();
        Console.WriteLine();
    }

    public void StartReflectionActivity()
    {
        Console.WriteLine();
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Spinner();
        Console.WriteLine();
        int duration = GetUserDuration();

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        Countdown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }

        Console.WriteLine();
        Console.WriteLine(GetEndMessage());
        Spinner();
        Spinner();
    }
}