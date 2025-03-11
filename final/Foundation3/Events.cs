public class Events()
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public string DisplayStandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }

    public string DisplayFullDetail()
    {
        return $"";
    }
}