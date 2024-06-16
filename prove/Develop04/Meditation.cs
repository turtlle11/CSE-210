
class Meditation: Activity
{

    public Meditation(string title, string description, int duration):base(title, description, duration)
    {
        _title = title;
        _description = description;
    }
    public void Display_Meditation_Activity()
    {
        Display_Start_Message(_title, _description);
        _time.Set_Time(_time.Ask_Duration());
        Console.Clear();
        Console.Write("Get ready, close your eyes, take comfort position clear your thoughts and relax.");
        Console.Write("\nStart and end your secion with beep sound");
        Anomation(10);
        Console.Beep();
        

        while (_time.Timer_Still_Counting()==true)
        {
            if (_time.Timer_Still_Counting()==false)
            {
                break;
            }
            Anomation(10000);
        }
        Console.Beep();

        
    }

    
}