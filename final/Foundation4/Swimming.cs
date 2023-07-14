public class Swimming : Activity
{
    // Attributes.
    double _laps;

    // Constructors.
    public Swimming(string activityType, string date, double duration, double laps)
    {
        _activityType = activityType;
        _date = date;
        _duration = duration;
        _laps = laps;
    }

    // Methods.
    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = 60 / CalculatePace();
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = _duration / CalculateDistance();
        return pace;
    }
}