class Address
{
    private string _address_of_street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address_of_street, string city, string state, string country)
    {
        _address_of_street = address_of_street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool Is_Local()
    {
        if(_country=="USA")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    // public bool Is_Local()
    // {
    //     return true;
    // }
    public string Get_Full_Address()
    {

        return $"{_address_of_street}, {_city}, {_state}, {_country}";
    }
}