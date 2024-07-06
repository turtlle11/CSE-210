public abstract class Goal
{
    protected bool _is_done;
    protected string _name_of_goal;
    protected string _goal_description;
    protected int _points;




    public Goal(string name, string description, int points)
    {
        _goal_description = description;
        _name_of_goal = name;
        _points = points;

    }



    public abstract void Get_New_Goal();
    
    public abstract void Display();
    public bool Get_Is_Done()
    {
        return _is_done;
    }
    
    public virtual int Set_Points()
    {
        return _points;
    }
    public abstract string GetStringRepresentation();
    public string Get_Name()
    {
        return _name_of_goal;
    }

}