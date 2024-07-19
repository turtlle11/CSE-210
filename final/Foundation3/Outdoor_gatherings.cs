class Outdoor_gatherings_event : Event
{
    protected string _statement_of_the_weather;
    public Outdoor_gatherings_event(string title, string description, Address address, string date, string time, string statement_of_the_weather, string type_of_event) : base(title, description, address, date, time, type_of_event)
    {
        _statement_of_the_weather = statement_of_the_weather;
    }
    public void Full_Event_Details()
    {
        Console.WriteLine($"Full {_type_of_event} event details\n");
        Console.WriteLine($"Title: {_event_title}\n\nDescription: {_event_description}\n\nDate: {_event_date}\n\nTime: {_event_time}\n\nStatement of the weather for this day: {_statement_of_the_weather} Address: {_event_address.Get_Full_Address()}");
    }


}