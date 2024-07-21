class Swimming: Activity
{
    protected float _number_of_laps;

    public Swimming(string date, float minutes, float number_of_laps): base(date, minutes)
    {
        _number_of_laps = number_of_laps;
    }

    public override float Get_Distance()
    {
        return _number_of_laps*50/1000;
    }
    public override float Get_Pace()
    {
        return _minutes/Get_Distance();
    }
    public override float Get_Speed()
    {
        return Get_Distance()/_minutes*60;
    }
    public override void Summary()
    {
    
        Console.WriteLine($"{_date} Swimming ({_minutes} min): Distance {Get_Distance()}km, Speed: {Get_Speed()}kph, Pace: {Get_Pace()} min per km");
    }
}