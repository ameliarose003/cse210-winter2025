public class OutdoorGatherings : Events
{
    private string _weather;

    public OutdoorGatherings(string weather, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor Gathering";
    }

    public string DisplayOutdoorGatheringDetail()
    {
        return $"Event: {base._title} \n {base._description} \n Weather: {_weather}";
    }
}