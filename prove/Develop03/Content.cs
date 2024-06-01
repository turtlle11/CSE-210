using System;

public class Content
{


    private List<string> _scrip = new List<string>(){
" Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.",
" And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge."
};


    private List<List<SetWord>> _verses = new List<List<SetWord>>();


    public Content()
    {
        for (int i = 0; i < _scrip.Count; i++)
        {
            List<SetWord> oneVers = new List<SetWord>();
            string[] array = _scrip[i].Split("");
            foreach (string strWord in array)
            {
                oneVers.Add(new SetWord(strWord, false));

            }
            _verses.Add(oneVers);
        }

    }

    public string GetVerses()
    {
        string verse = "";
        int number = 0;
        foreach (List<SetWord> oneVers in _verses)
        {
            foreach (SetWord word in oneVers)
            {
                verse = verse + " " + word.GetWord();
                number = number +1;
            }
            verse = verse + "\n";
        }
        Console.WriteLine(number);
        return verse;
    }

// public int NumberOfWords(){
//     int number = 0;
//     foreach (List<SetWord> oneVers in _verses)
//         {
//             foreach (int i = 0; i<oneVers.Count; i++)
//             {
//                 number = number +1;

//             }
//         }
//     return number;
// }

    // public List<string> GetScrip()
    // {
    //     return _scrip;
    // }

}


//   "1 Nephi 1:2-3"