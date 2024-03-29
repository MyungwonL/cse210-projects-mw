class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public decimal GetShippingCost()
    {
        if (IsInUSA())
            return 5;
        else
            return 35;
    }

    public Address GetAddress()
    {
        return _address;
    }
}