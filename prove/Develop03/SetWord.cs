using System;

public class SetWord
{
    private string _word;
    private bool _isHidden;

    public SetWord(string word, bool isHidden){
        _word = word;
        _isHidden = isHidden;
    }

    public void SetHidden()
    {

        string hidden_word = "";
        foreach(char letter in _word){
            hidden_word = hidden_word + "_";

        }
        _word = hidden_word;
        _isHidden = true;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool GetHiddenStatus()
    {
        return _isHidden;
    }

}