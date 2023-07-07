public class Address
{
    // Attributes.
    string _streetAddress;
    string _city;
    string _stateProvince;
    string _country;

    // Constructors.
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }


    // Methods.
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetStateProvince()
    {
        return _stateProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public bool USAorNot()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
            return false;
    }
    public string FullAddress()
    {
        string fullAddress = $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
        return fullAddress;
    }
    
}