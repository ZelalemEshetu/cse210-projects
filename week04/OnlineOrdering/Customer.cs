using System;

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName() => name;

    public bool IsInUSA() => address.IsInUSA();

    public string GetAddressString() => address.GetFullAddress();
}
