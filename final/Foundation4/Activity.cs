public abstract class Activity
{
    // Attributes.
    protected string _activityType;
    protected string _date;
    protected double _duration;

    // Constructors.


    // Methods.
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public string GetSummary()
    {
        string summary = $"{_date} {GetActivityType()} ({_duration} min)- Distance: {CalculateDistance().ToString("F2")} miles, Speed: {CalculateSpeed().ToString("F2")} mph, Pace: {CalculatePace().ToString("F2")} min per mile";
        return summary;
    }
    public string GetActivityType()
    {
        return _activityType;
    }
}