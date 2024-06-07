using System;

public class Content
{
    private List<string> _scrip = new List<string>()
    {
        "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.",
        "And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge."
    };

    private List<List<SetWord>> _verses = new List<List<SetWord>>();
    private NumberGen _number;
    private int total_Not_Hidden_Words_Number = 0;

    public Content()
    {
        _number = new NumberGen();
        for (int i = 0; i < _scrip.Count; i++)
        {
            List<SetWord> oneVers = new List<SetWord>();
            string[] array = _scrip[i].Split(" ");
            foreach (string strWord in array)
            {
                oneVers.Add(new SetWord(strWord, false));
                total_Not_Hidden_Words_Number++;
            }
            _verses.Add(oneVers);
        }
    }

    public void DisplayVerses()
    {
        foreach(List<SetWord> listOfWords in _verses)
        {
            string row = "";

            foreach(SetWord word in listOfWords)
            {
                row += word.GetWord() + " ";
            }
            Console.WriteLine(row);
        } 
        
        if (total_Not_Hidden_Words_Number == 0)
            System.Environment.Exit(0);
    }

    public void ChangeVerses()
    {
        total_Not_Hidden_Words_Number = 0;
        
        foreach (List<SetWord> oneVers in _verses)
        {
            int notHiddenWordsNumber = GetNotHiddenWordsNumber(oneVers);
            total_Not_Hidden_Words_Number += notHiddenWordsNumber;

            if (notHiddenWordsNumber == 0)
                continue;
                
            else if (notHiddenWordsNumber == 1)
            {
               HideRandomWord(oneVers);
            }
            else
            {
                for(int j = 0; j<2; j++)
                {
                    HideRandomWord(oneVers);
                }    
            }
        }
    }

    private void HideRandomWord(List<SetWord> oneVers)
    {
        int indexOfWord=_number.GenNumber(oneVers.Count());

        while (oneVers[indexOfWord].GetHiddenStatus() == true)
            indexOfWord = _number.GenNumber(oneVers.Count());

        oneVers[indexOfWord].SetHidden(); 
    }

    private int GetNotHiddenWordsNumber(List<SetWord> oneVers)
    {
        int notHiddenWordsNumber = 0;
        for (int i = 0; i < oneVers.Count(); i++)
        {
            if (oneVers[i].GetHiddenStatus() != true)
            {
                notHiddenWordsNumber++;
            }
        }
        return notHiddenWordsNumber;
    }
}

//   "1 Nephi 1:2-3"