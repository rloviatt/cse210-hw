using System;

public class Activity
{
    protected string _date;
    protected int _length; // in minutes
    protected string _name;

    public Activity(string date, int length, string name)
    {
        _date = date;
        _length = length;
        _name = name;
    }

    public virtual double Distance()
    {
        return 0;
    }

    public virtual double Speed()
    {
        return 0;
    }

    public virtual double Pace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_length} min) - Distance: {Distance()} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile";
    }
}