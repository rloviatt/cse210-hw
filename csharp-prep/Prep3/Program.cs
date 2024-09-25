using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        string keepPlaying = "y";
        while (keepPlaying == "y")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guess = -1;
            int attempts = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    attempts ++;
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    attempts ++;
                    Console.WriteLine("Lower");
                }
                else
                {
                    attempts ++;
                    guess = magicNumber;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Correct! The magic number is {magicNumber}.");
            Console.WriteLine($"You guessed it in {attempts} attempts.");
            Console.Write("Would you like to keep playing (y/n)? ");
            string userAnswer = Console.ReadLine();
            keepPlaying = userAnswer;
            Console.WriteLine();
        }
    }
}