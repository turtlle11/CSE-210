using System;

class Program
{
    static void Main(string[] args)
    {
        string end = "";
        Content verses = new Content();
        ScripReference references = new ScripReference("1 Nephi", 1, 2, 3);
        
       while(end!= "quit")
       {
            references.DisplayRef();
            StartNewRound(verses);
            end = Console.ReadLine();
       }
    }

    public static void StartNewRound(Content verses)
    {
        verses.DisplayVerses();
        verses.ChangeVerses();
    }
}