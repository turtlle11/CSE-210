class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing(string title, string description, int duration) : base(title, description, duration)
    {
        _title = title;
        _description = description;
    }

    public void Display_Listing_Activity()
    {
        int number=0;
        Display_Start_Message(_title, _description);
        _time.Set_Time(_time.Ask_Duration());
        Console.Clear();
        Console.Write("Get ready");
        Anomation(5);
        string chosen_promp = GenPrompt(_prompts);
        Console.WriteLine($"Your prompt is:\n{chosen_promp}");
        Console.WriteLine($"Think about it for 10 seconds");
        Console.Write("Get ready");
        Anomation(10);
        Console.WriteLine("\nYou may beging\n");
        while (_time.Timer_Still_Counting())
        {
            
            number++;
            Console.ReadLine();
            
        }
        Console.WriteLine($"You listed {number} items.");

    }


}