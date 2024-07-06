class Eternal: Goal
{
    public Eternal(string name_of_goal, string description_of_goal, int points):base(name_of_goal, description_of_goal, points)
    {
    }
    public override void Get_New_Goal()
    {
        Console.WriteLine("What Eternal goal do you want to create?");
        string name_of_goal = Console.ReadLine();
        Console.WriteLine("What is the description of your goal?");
        string description_of_goal = Console.ReadLine();
        Console.WriteLine("How many point this goal worth for each repitition?");
        int points = int.Parse(Console.ReadLine());
        this._name_of_goal = name_of_goal;
        this._goal_description = description_of_goal;
        this._points = points; 
    }

    public override void Display()
    {
         Console.WriteLine($"{this._name_of_goal} ({this._goal_description}) {this._points} points each time.");
    }
        public override string GetStringRepresentation() 
    {
        return $"{this._name_of_goal}: {this._goal_description}: {this._points}";
    }




}