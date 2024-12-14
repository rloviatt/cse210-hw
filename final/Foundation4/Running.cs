public class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, int length, double distance)
        : base(date, length, "Running")
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return (_distance / _length) * 60;
    }

    public override double Pace()
    {
        return _length / _distance;
    }
}