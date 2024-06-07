using System;

public class NumberGen
{
    public int GenNumber(int wordsCount)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, wordsCount);
        return number;
    }
}