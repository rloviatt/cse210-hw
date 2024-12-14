public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, int length, double speed)
        : base(date, length, "Cycling")
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return (_speed * _length) / 60;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }
}