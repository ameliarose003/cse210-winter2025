public class CyclingActivity : ExerciseActivity
{
    private double _speed;

    public CyclingActivity(double speed, int duration, string date) : base(duration, date)
    {
        _speed = speed;
    }

    public override string GetName()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return _speed * _duration;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }

}