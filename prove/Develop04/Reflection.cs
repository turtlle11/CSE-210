class Reflection : Activity
{
    private List<string> _start_prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _follow_prompts = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection(string title, string description, int duration) : base(title, description, duration)
    {
        _title = title;
        _description = description;
    }

    public void Display_Reflaction_Activity()
    {
        Display_Start_Message(_title, _description);
        _time.Set_Time(_time.Ask_Duration());
        Console.Clear();
        Console.Write("Get ready");
        Anomation(5);
        string chosen_promp = GenPrompt(_start_prompts);
        Console.WriteLine($"\nYour prompt is:\n{chosen_promp}");
        

        while (_time.Timer_Still_Counting())
        {
            string follow = GenPrompt(_follow_prompts);
            Console.Write($"\nReflect on this:\n{follow}");
            Anomation(8);
        }
    
    }



}