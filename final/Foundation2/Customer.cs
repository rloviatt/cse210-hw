using System;

public class Customer
{
    private string _givenName;
    private string _familyName;
    private Address _address;

    public Customer(string givenName, string familyName, Address address)
    {
        _givenName = givenName;
        _familyName = familyName;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.CheckUSA();
    }

    public string CompleteCustomer()
    {
        return $"{_givenName} {_familyName}\n{_address.CompleteAddress()}";
    }
}