public class Running : Activity
{
    // Attributes.
    double _distance;

    // Constructors.
    public Running(string activityType, string date, double duration, double distance)
    {
        _activityType = activityType;
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    // Methods.
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (_distance / _duration) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = _duration / _distance;
        return pace;
    }
}