using System;

public class HideWord{



private List<int> _numbers = new List<int>();

// public HideWord(List<int> number){
//     _numbers = number;
// }
NumberGen number = new NumberGen();
private string chosenWord = "";
SetWord word = new SetWord(chosenWord, false);
public string HideWords(){
    int newNumber;
    string hidden = "";
    int count = 0;
    while(count!=3 ){
        
        newNumber = number.GenNumber() ;
        _numbers.Add(newNumber);
        if(!_numbers.Contains(newNumber)){
            count = count+1;

        }

    }
    


    foreach(int number in _numbers){
        Console.WriteLine(number);
    }
    
    return hidden ;
}

}