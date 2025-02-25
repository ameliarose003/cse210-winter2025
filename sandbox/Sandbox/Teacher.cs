using System.Reflection.Metadata.Ecma335;

public class Teacher : Staff
{
    private int _roomNumber;

    public Teacher(int roomNumber, string firstName, string lastName, string gender) : base(firstName, lastName, gender)
    {
        _roomNumber = roomNumber;
    }

    public string DisplayGreeting()
    {
        return $"Hello, I am {GetProfessionalName()} and I work in room {_roomNumber}";
    }
}