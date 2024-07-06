class Video
{
    private string _video_title;
    private string _author;
    private string _length_of_video;
    private List<string> _comments = new List<string>();

    public Video(string title, string author, string length, List<string> comments)
    {
        _video_title = title;
        _author = author;
        _length_of_video = length;
        _comments = comments;
    }

    public string Get_Author()
    {
        return _author;
    }
    public string Get_Length()
    {
        return _length_of_video;
    }
    public string Get_Title()
    {
        return _video_title;
    }
    public List<string> Get_Comments()
    {
        return _comments;
    }
    public int Number_of_points()
    {
        int number_of_points = 0;
        for (int i = 0; i < _comments.Count; i++)
        {
            number_of_points = i;
        }

        return number_of_points;
    }

    public void Display_All()
    {
        Console.WriteLine($"{_video_title}");
        Console.WriteLine($"{_author}");
        Console.WriteLine($"{_length_of_video}");
        foreach(string comment in _comments)
        {
            Console.WriteLine($"{comment}");
        }
        
    }
}