using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? Write a number without % sign");

        string grade = Console.ReadLine();

        int percent_grade = int.Parse(grade);

        string letter_grade = "";

         if (percent_grade >= 90)
        {
           letter_grade = "A";
        }
        else if (percent_grade >= 80)
        {
            letter_grade = "B";
        }
        else if (percent_grade >= 70)
        {
            letter_grade = "C";
        }
        else if (percent_grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }

        Console.WriteLine("Your grade is:" + letter_grade);
        
        if (percent_grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}