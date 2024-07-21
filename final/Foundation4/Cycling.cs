class Cycling: Activity
{
    protected float _speed;

    public Cycling(string date, float minutes, float speed): base(date, minutes)
    {
        _speed = speed;
    }

    public override float Get_Distance()
    {
        return _speed * _minutes/60;
    }
    public override float Get_Pace()
    {
        return _minutes/Get_Distance();
    }
    public override float Get_Speed()
    {
        return _speed;
    }
    public override void Summary()
    {
    
        Console.WriteLine($"{_date} Cycling({_minutes} min): Distance {Get_Distance()}km, Speed: {Get_Speed()}kph, Pace: {Get_Pace()} min per km");
    }
}