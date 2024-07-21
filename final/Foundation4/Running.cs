class Running: Activity
{
    protected float _distance;

    public Running(string date, float minutes, float distance): base(date, minutes)
    {
        _distance = distance;
    }

    public override float Get_Distance()
    {
        return _distance;
    }
    public override float Get_Pace()
    {
        return _minutes/_distance;
    }
    public override float Get_Speed()
    {
        return _distance/_minutes*60;
    }
    public override void Summary()
    {
    
        Console.WriteLine($"{_date} Running ({_minutes} min): Distance {_distance}km, Speed: {Get_Speed()}kph, Pace: {Get_Pace()} min per km");
    }
}