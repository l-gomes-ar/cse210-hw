using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        do 
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;

            int countGuess = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                countGuess++;

                if (guess < magicNumber) 
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            } while (guess != magicNumber);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Total number of guesses: {countGuess}");

            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}