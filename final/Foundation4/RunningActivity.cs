public class RunningActivity : ExerciseActivity
{
    private double _distance;

    public RunningActivity(double distance, int duration, string date) : base(duration, date)
    {
        _distance = distance;
    }

    public override string GetName()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }

}