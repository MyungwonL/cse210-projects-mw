using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);
        int guess = 0;

        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNum) {
                Console.Write("You guessed it!");
            }

            else if (guess > magicNum) {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNum) {
                Console.WriteLine("Higher");
            }
        } while (guess != magicNum);
    }
}