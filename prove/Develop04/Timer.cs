class Time
{
   private int _duration;
   private DateTime _futureTime;
    public Time()
    {
        
    }
    public int Ask_Duration()
    {
        Console.WriteLine("Enter your session time:");
        string time = Console.ReadLine();
        _duration = int.Parse(time);
        return _duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Set_Time(int duration)
    {
        DateTime startTime = DateTime.Now;
        _futureTime = startTime.AddSeconds(duration);
    }
    public bool Timer_Still_Counting()
    {
        DateTime currentTime = DateTime.Now;
        if (currentTime < _futureTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}