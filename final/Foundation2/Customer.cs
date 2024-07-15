class Customer
{
    private string _customer_name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _address = address;
        _customer_name = name;
    }
    
    public bool Is_Local()
    {
        if(_address.Is_Local() is true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public string Get_Name()
    {
        return _customer_name;
    }
    public Address Get_Address()
    {
        return _address;
    }
}