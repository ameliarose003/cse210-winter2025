public class SwimmingActivity : ExerciseActivity
{
    private double _laps;

    public SwimmingActivity(double laps, int duration, string date) : base(duration, date)
    {
        _laps = laps;
    }

    public override string GetName()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }

}