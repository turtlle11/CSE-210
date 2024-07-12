class Video
{
    private string _video_title;
    private string _author;
    private string _length_of_video;
    private List<Comments> _comments;


    public Video(string title, string author, string length)
    {
        _video_title = title;
        _author = author;
        _length_of_video = length;
        _comments = new List<Comments>();

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
    public List<Comments> Get_Comments()
    {
        return _comments;
    }


    public void Display_All()
    {
        Console.WriteLine($"Title of the video: {_video_title}");
        Console.WriteLine($"Author's name: {_author}");
        Console.WriteLine($"Length of the video: {_length_of_video}\n");
        Console.WriteLine("Comments:");
        foreach( Comments particle in _comments)
        {
            Console.WriteLine($"{particle.Display_one_comment()}");
        }
        Console.WriteLine($"Number of comments: {Number_of_comments()}\n");
        
    }
    public int Number_of_comments()
    {
        int number_of_comments = 0;
        for (int i = 0; i <= _comments.Count; i++)
        {
            number_of_comments = i;
        }

        return number_of_comments;
    }
}