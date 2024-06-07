using System;

public class ScripReference{
    private string _book;
    private int _firstVerse;
    private int _lastVerse;
    private int _chapter;

   
// 1 Nephi 1:2-3
    public ScripReference(string book, int chapter, int firstVerse, int lastVers )
    {
        _book = book;
        _firstVerse = firstVerse;
        _lastVerse = lastVers ;
        _chapter = chapter; 

    }
     public void DisplayRef()
    {
        Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
    }
}