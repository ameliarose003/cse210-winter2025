public class Events
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;

    public Events(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }

    public string DisplayStandardDetails()
    {
        return $"{_title} \n {_description}\n Date: {_date} \n Time: {_time}\n Address: {_address}";
    }

    public string DisplayFullDetail()
    {
        return $"{_eventType} Event: {_title} \n {_description}\n Date: {_date} \n Time: {_time}\n Address: {_address}";
    }


    public string ShortDescription()
    {
        return $"{_eventType} Event: {_title} \n Date: {_date}";
    }
}