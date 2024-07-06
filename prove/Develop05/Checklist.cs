class Checklist: Goal
{
    private int _attempts = 0;
    private int _points_for_attempt = 0;
    private int _bonus_points;
    private string _done_sign = "[ ]";
    private int _check_attempts;
    public Checklist(string done_sign, string name_of_goal, string description_of_goal, int points, int points_for_attempt, int attempts, int bonus_points, int check_attempts):base(name_of_goal, description_of_goal, points)
    {
        _done_sign = done_sign;
        _bonus_points = bonus_points;
        _points_for_attempt = points_for_attempt; 
        _attempts = attempts; 
        _check_attempts = check_attempts;
    }



    public override void Get_New_Goal()
    {

        Console.WriteLine("What Checlist goal do you want to create?");
        string name_of_goal = Console.ReadLine();
        Console.WriteLine("What is the description of your goal?");
        string description_of_goal = Console.ReadLine();
        Console.WriteLine("How many point this goal worth for each repititon?");
        int _points_for_attempt = int.Parse(Console.ReadLine());
        Console.WriteLine("For how many attempts do you want to do it?");
        int _attempts = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points do you want to get?");
        int _bonus_points = int.Parse(Console.ReadLine());
        this._check_attempts = 0;
        this._name_of_goal = name_of_goal;
        this._goal_description = description_of_goal;
        this._points_for_attempt = _points_for_attempt;
        this._attempts = _attempts;
        this._bonus_points = _bonus_points;
    }     
        public override void Display()
    {
        
        Console.WriteLine($"{this._done_sign} {this._name_of_goal} ({this._goal_description}) {this._points_for_attempt} points each attempt, Completed: {_check_attempts}/{this._attempts}, Your bonus: {_bonus_points}");
    }
        public override string GetStringRepresentation() 
    {
        return $"{this._done_sign}: {this._name_of_goal}: {this._goal_description}: {this._points_for_attempt}: {_check_attempts}: {this._attempts}: {_bonus_points}";
    }

    public override int Set_Points()
    {
        _check_attempts++;
        if (_check_attempts!=_attempts)
        {

            return _points_for_attempt;
        }
        else
        {

            _done_sign = "[X]";
             return _points_for_attempt+_bonus_points;
        }
    }
    


}