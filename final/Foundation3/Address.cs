class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _city = city;
        _country = country;
        _state = state;
        _street = street;
    }
    public string Get_Full_Address()
    {
        return $"\nStreet: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }
}