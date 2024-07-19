class Receptions_event : Event
{
    protected string _RSVP;
    public Receptions_event(string title, string description, Address address, string date, string time, string type_of_event, string RCVP) : base(title, description, address, date, time, type_of_event)
    {
        _RSVP = RCVP;
    }
    public void Full_Event_Details()
    {
        Console.WriteLine($"Full {_type_of_event} event details\n");
        Console.WriteLine($"Title: {_event_title}\n\nDescription: {_event_description}\n\nDate: {_event_date}\n\nTime: {_event_time}\n\nAddress: {_event_address.Get_Full_Address()}\n\nRCVP email: {_RSVP}");
    }


}