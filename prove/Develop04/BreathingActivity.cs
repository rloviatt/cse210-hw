using System;

public class BreathingActivity : Activity
{
    private string _breatheInMessage = "Breathe in...";
    private string _breatheOutMessage = "Now breathe out...";

    public BreathingActivity() : base("Breathing Activty", 
                "Welcome to the Breathing Activity", 
                "This activity will you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
                "Well done!! You have complete the Breathing Activity.", 0)
    {
    }

    private void DisplayBreatheInAndOut()
    {
        Console.WriteLine();
        Console.Write(_breatheInMessage + " ");
        Countdown(4);
        Console.WriteLine();
        Console.Write(_breatheOutMessage + " ");
        Countdown(6);
        Console.WriteLine();
    }

    public void StartBreathingActivity()
    {
        Console.WriteLine();
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Console.WriteLine();
        int duration = GetUserDuration();
        Spinner();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayBreatheInAndOut();
        }

        Console.WriteLine();
        Console.WriteLine(GetEndMessage());
        Spinner();
        Spinner();
    }
}