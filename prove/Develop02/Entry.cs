using System;

public class Entry{
    public string _givenPrompt;
    public string _entryDateTime;
    public string _givenResponse;

    public void Display1(){
        Console.WriteLine($"Prompt: {_givenPrompt}\nYour response: {_givenResponse}\nDate: {_entryDateTime}");
    }

    public void GetResponse(){
        Console.WriteLine("");
    }



}

    