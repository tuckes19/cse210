public class Cycling : Activity
{
    // Attributes.
    double _speed;

    // Constructors.
    public Cycling(string activityType, string date, double duration, double speed)
    {
        _activityType = activityType;
        _date = date;
        _duration = duration;
        _speed = speed;
    }

    // Methods.
    public override double CalculateDistance()
    {
        double distance = _speed * (_duration / 60);
        return distance;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        double pace = _duration / CalculateDistance();
        return pace;
    }
}