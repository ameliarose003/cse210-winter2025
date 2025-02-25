public class Volunteer : Staff
{
    public Volunteer(string firstName, string lastName, string gender) : base(firstName, lastName, gender)
    {

    }
    public string DisplayGreeting()
    {
        return $"Hello, I am {GetProfessionalName()} and I am a volunteer";
    }
}