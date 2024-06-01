using System;

public class SetWord{


private string _word;
private bool _isHidden;

//Content scripture = new Content(object.GetScrip);

// private string[] words = {};
// public void SeparateScrip(){
//     foreach( string word in scrip){
//           string[] wor = line.Split(",");

//     }
// }
public SetWord(string word, bool isHidden){
    _word = word;
    _isHidden = isHidden;
}
// public void Word(){

// }
// public void HideWord(){

// }
// public void ChooseWord(){

// }
public void SetHidden(){
    string letter = "";
    foreach(char i in _word){
        letter = letter + "_";

    }
    _word = letter;
    _isHidden = true;
}
public string GetWord(){
    return _word;
}


}