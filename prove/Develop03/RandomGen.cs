using System;

public class NumberGen{
        public int GenNumber(){
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0,24);

            return number;

       }
 }