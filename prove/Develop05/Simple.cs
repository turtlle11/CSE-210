class Simple : Goal
{
    private string _done_sign = "[ ]";
    public Simple(string done_sign,string name_of_goal, string description_of_goal, int points) : base(name_of_goal, description_of_goal, points)
    {
        _done_sign = done_sign;
    }

    public override void Display()
    {
        Console.WriteLine($"{this._done_sign} {this._name_of_goal} ({this._goal_description}) {this._points} points");
    }

    public override void Get_New_Goal()
    {
        Console.WriteLine("What simple goal do you want to create?");
        string name_of_goal = Console.ReadLine();
        Console.WriteLine("What is the description of your goal?");
        string description_of_goal = Console.ReadLine();
        Console.WriteLine("How many point this goal worth?");
        int points = int.Parse(Console.ReadLine());
        this._name_of_goal = name_of_goal;
        this._goal_description = description_of_goal;
        this._points = points; 
    }

    public override string GetStringRepresentation() 
    {
        return $"{this._done_sign}: {this._name_of_goal}: {this._goal_description}: {this._points}";
    }

     public override int Set_Points()
    {
        _done_sign = "[X]";
        return _points;
    }


}