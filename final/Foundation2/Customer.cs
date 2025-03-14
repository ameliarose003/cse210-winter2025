using System.Net.Sockets;

public class Customer
{
    private string _name;
    public Address _address = new Address();

    public Customer(string name)
    {
        _name = name;
    }

    public string PersonalShippingInfo(string customerAddress)
    {
        return $"{_name} \n {customerAddress}";
    }

    public bool IsUsaResident()
    {
        return _address.InUsa();
    }
}


