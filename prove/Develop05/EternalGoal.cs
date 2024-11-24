public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Add points to user's total points (this would be handled in the Program class)
        // Do not change the completion status
    }
    public override string SaveGoal()
    {
        return $"EternalGoal:{Name},{Description},{Points},{CompletionStatus}";
    }
}