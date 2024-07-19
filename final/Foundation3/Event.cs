class Event
{
    protected string _event_title;
    protected string _event_time;
    protected string _event_date;
    protected Address _event_address;
    protected string _event_description;
    protected string _type_of_event;

    public Event(string title, string description, Address address, string date, string time, string type_of_event)
    {
        _event_title = title;
        _event_time = time;
        _event_date = date;
        _event_description = description;
        _event_address = address;
        _type_of_event = type_of_event;
    }

        public void Standard_Event_Details()
    {
        Console.WriteLine($"Standard {_type_of_event} event details\n");
        Console.WriteLine($"Title: {_event_title}\n\nDescription: {_event_description}\n\nDate: {_event_date}\n\nTime{_event_time}\n\nAddress: {_event_address.Get_Full_Address()}");
    }

        public void Short_Event_Details()
    {
        Console.WriteLine($"Short {_type_of_event} event details\n");
        Console.WriteLine($"Type of event: {_type_of_event}\n\nTitle: {_event_title}\n\nDate: {_event_date}");
    }

}