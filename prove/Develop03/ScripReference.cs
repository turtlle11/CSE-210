using System;

public class ScripReference{
    private string _book;
    private int _firstVerse;
    private int _lastVerse;
    private int _chapter;

    public void DisplayRef(){
        Console.WriteLine(_book, _chapter, _firstVerse, _lastVerse );
    }
    public ScripReference(string book, int firstVerse, int lastVers, int chapter){
        _book = book;
        _firstVerse = firstVerse;
        _lastVerse = lastVers;
        _chapter = chapter; 

    }
}