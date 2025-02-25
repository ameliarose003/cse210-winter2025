using System.Security.Cryptography.X509Certificates;

public class Staff
{
    private string _firstName;
    private string _lastName;
    private string _gender;

    public Staff(string firstName, string lastName, string gender)
    {
        _firstName = firstName;
        _lastName = lastName;
        _gender = gender;

    }

    public string GetTitle()
    {
        if (_gender.ToLower() == "m")
        {
            return "Mr.";
        }
        else return "Mrs.";
    }

    public string GetProfessionalName()
    {
        string title = GetTitle();
        return title + " " + _lastName;
    }
}