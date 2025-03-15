public class Lectures : Events
{
    // public string _eventType = "Lecture";
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public string DisplayLectureDetail()
    {
        return $"\n Speaker: {_speaker} \n Capacity: {_capacity}";
    }


}