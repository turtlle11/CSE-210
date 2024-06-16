
class Breathing: Activity
{

    public Breathing(string title, string description, int duration):base(title, description, duration)
    {
        _title = title;
        _description = description;
    }
    public void Display_Breathing_Activity()
    {
        int repitition = 5;
        Display_Start_Message(_title, _description);
        _time.Set_Time(_time.Ask_Duration());
        Console.Clear();
        Console.Write("Get ready");
        Anomation(6);
        
        while (_time.Timer_Still_Counting())
        {
            Console.Write("\nBreath in");
            Anomation(repitition);
            Console.Write("\nBreath out");
            Anomation(repitition);
        }
    }
}