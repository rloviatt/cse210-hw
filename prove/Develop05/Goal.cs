using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    protected string _completionStatus;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completionStatus = "[ ]";
    }

    public virtual void RecordEvent()
    {
        _completionStatus = "[X]";
        // Add points to user's total points (this would be handled in the Program class)
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_completionStatus} {_name} ({_description})");
    }

    public virtual string SaveGoal()
    {
        return $"Goal:{_name},{_description},{_points},{_completionStatus}";
    }

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;
    public string CompletionStatus
    {
        get => _completionStatus;
        set => _completionStatus = value;
    }
}