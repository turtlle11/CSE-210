class Lectures_event: Event
{
    protected string _lecturer;
    protected string _capacity;

    public Lectures_event(string title, string description, Address address, string date, string time, string lecturer, string capacity, string type_of_event): base(title, description, address, date, time, type_of_event)
    {
        _lecturer = lecturer;
        _capacity = capacity;
    }
        public void Full_Event_Details()
    {
        Console.WriteLine($"Full {_type_of_event} event details\n");
        Console.WriteLine($"Title: {_event_title}\n\nDescription: {_event_description}\n\nCapacity: {_capacity}\n\nLecturer name: {_lecturer}\n\nDate: {_event_date}\n\nTime: {_event_time}\n\nAddress: {_event_address.Get_Full_Address()}\n");
    }



}