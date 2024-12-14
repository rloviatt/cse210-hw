public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps)
        : base(date, length, "Swimming")
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000.0 * 0.62; // converting meters to miles
    }

    public override double Speed()
    {
        return (Distance() / _length) * 60;
    }

    public override double Pace()
    {
        return _length / Distance();
    }

    public override string GetSummary()
    {
        return $"{_date} {_name} ({_length} min) - Distance: {Distance()} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile, Laps: {_laps}";
    }
}