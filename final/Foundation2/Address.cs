using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CheckUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string CompleteAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}