public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusPoints)
        : base(name, description, points)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        // Add points to user's total points (this would be handled in the Program class)
        if (_timesCompleted == _timesToComplete)
        {
            // Add bonus points to user's total points
            // Change completion status
            _completionStatus = "[X]";
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_completionStatus} {Name} ({Description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{CompletionStatus},{_timesCompleted},{_timesToComplete},{_bonusPoints}";
    }
}