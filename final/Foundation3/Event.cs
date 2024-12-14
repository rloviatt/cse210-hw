public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string DisplayStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.CompleteAddress()}";
    }

    public virtual string DisplayFullDetails()
    {
        return DisplayStandardDetails();
    }

    public string DisplayShortDescription()
    {
        return $"Type: {_type}\nTitle: {_title}\nDate: {_date}";
    }
}