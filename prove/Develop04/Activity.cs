class Activity
{
    //Atributs
    protected string _title;
    protected string _description;

    protected Time _time;

    // Constractor
    public Activity(string title, string description, int duration)
    {
        _time = new Time();
        _title = title;
        _description = description;

    }


    public string GenPrompt(List<string> prompts)
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
    public void Display_Start_Message(string title, string description)
    {
        Console.WriteLine($"{title}\n{description}");

    }
    public void Display_End_Message(string title)
    {
        Console.WriteLine($"\nThank you for using {title} for {_time.GetDuration()} seconds.\nBe Mindfull and have a good day!");

    }

    public void Anomation(int repitition)
    {
        // if(_time.Timer_Still_Counting())
        // {
            for(int i = 0; i<repitition; i++){
            foreach(string frame in new List<string>(){"|","\\","-","/","|","\\","-","/"})
            {
                Console.Write(frame);
                Thread.Sleep(125);
                Console.Write("\b \b"); 
            }
            }
        // }
       
    }
}