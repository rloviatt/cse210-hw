public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string DisplayFullDetails()
    {
        return $"{DisplayStandardDetails()}\nType: {_type}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}