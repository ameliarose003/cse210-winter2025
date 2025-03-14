public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public void SetAddress(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string MakeAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }

    public bool InUsa()
    {
        if (!string.IsNullOrEmpty(_country) &&
            (_country.ToLower() == "usa" ||
             _country.ToLower() == "united states" ||
             _country.ToLower() == "us"))
        {
            return true;
        }
        return false;
    }
}