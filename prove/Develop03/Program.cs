using System;

class Program
{
    static void Main(string[] args)
    {
        string end = "";
       while(end!= "quit"){
        SetWord word = new SetWord("Yea", false);
        Console.WriteLine(word.GetWord());
        word.SetHidden();
        
        Console.WriteLine(word.GetWord());

        Content verses = new Content();
        Console.WriteLine(verses.GetVerses());
        NumberGen number = new NumberGen();
        Console.WriteLine(number.GenNumber());
        HideWord hidden = new HideWord();
        Console.WriteLine(hidden.HideWords());
        Console.ReadLine();
       }
    }
}