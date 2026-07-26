using System;

namespace ConsoleApp1
{
    class Seatwork
    {
        static void Main(string[] sigma)
        {
            Random random = new Random();
            int secret= random.Next(1, 101);
            int guess = 0;
            int attempts = 0;
            /*
            Console.WriteLine("Number Guessing Game"
            + "\nGuess a number between 1 and 100");

            while (guess != secret)
            {
                Console.Write("Enter your guess"
                + "\n\t> ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > secret)
                {
                    Console.WriteLine("Too high");
                    attempts++;
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Too low");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("It took you " + attempts + " attempts to guess the number.");
                }

            } */
        
            do
            {
                Console.WriteLine("Guess a number between 1 and 100");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > secret)
                {
                    Console.WriteLine("Too high"); 
                    attempts++;
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Too low");
                    attempts++;
                }
            } while (guess != secret);
            Console.WriteLine("You guessed it!");
            Console.WriteLine("It took you " + attempts + " attempts to guess the number.");
        }
    }
}