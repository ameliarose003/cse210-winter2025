using System.Net.Sockets;

public class Customer
{
    public string _name;
    public Address _address = new Address();
    public bool IsUsaResident()
    {
        return _address.IsUsaResident();
    }
}


