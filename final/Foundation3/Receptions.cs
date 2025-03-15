public class Receptions : Events
{
    private string _rsvp;
    public Receptions(string rsvpEmail, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _rsvp = rsvpEmail;
        _eventType = "Reception";
    }

    public string DisplayReceptionDetail()
    {
        return $"Event: {base._title} \n {base._description} \n RSVP: {_rsvp}";
    }
}