class Comments
{
    private string _comments_author_name;
    private string _comment;


    public Comments(string name, string comment )
    {
        _comments_author_name = name;
        _comment = comment;
    }

    public string Get_Comments()
    {
        return _comment;
    }

    public string Display_one_comment()
    {
        return $"{_comments_author_name}: {_comment}";
    }


}