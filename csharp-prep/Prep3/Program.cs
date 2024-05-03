using System;

class Program
{
    static void Main(string[] args)
    {
         Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int attempt = 0;
        Console.WriteLine("Try to guess a number!");
        while (guess != magicNumber)
        {   
            attempt = attempt + 1;
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! You used {attempt} tries.");
            }

        }
    }
}