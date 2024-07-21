public abstract class Activity
{
    protected string _date;
    protected float _minutes;

    public Activity(string date, float minutes)
    {
        _date = date;
        _minutes = minutes;
    }


    public abstract float Get_Distance();
    public abstract float Get_Pace();
    public abstract float Get_Speed();
    public abstract void Summary();
    
}