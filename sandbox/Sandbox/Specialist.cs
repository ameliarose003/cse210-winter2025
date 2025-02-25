public class Specialist : Staff
{
    private string _specialty;

    public Specialist(string specialty, string firstName, string lastName, string gender) : base(firstName, lastName, gender)
    {
        _specialty = specialty;
    }

    public string DisplayGreeting()
    {
        return $"Hello, I am {GetProfessionalName()} and I specialize in {_specialty}";
    }
}