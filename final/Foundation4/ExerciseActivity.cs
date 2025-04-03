public abstract class ExerciseActivity
{
    protected int _duration;
    protected string _date;

    public ExerciseActivity(int duration, string date)
    {
        _duration = duration;
        _date = date;
    }

    public abstract string GetName();

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string DisplaySummary()
    {

        return $"{_date} {GetName()} ({_duration} min)- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}