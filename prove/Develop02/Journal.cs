using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    string fileName = "C#team.txt";
    public void AddEntry(Entry Bp){
        _entries.Add(Bp);
    }
    Entry k = new Entry();
    public void Display2(){
        List<Entry> list= new List<Entry>();
        list = _entries;
        foreach(Entry k in list){
            k.Display1();
        }
    }
    public void Save(){


    
    }
}
