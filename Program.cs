using System;
namespace guessnumber
{
    class GuessTheNumber
    {
        static void Main()
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 20); // Random number between 1 and 20
            int numberOfTries = 0;
            bool hasGuessedCorrectly = false;

            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("I have selected a number between 1 and 20. Can you guess it?");

            while (!hasGuessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                string userInput = Console.ReadLine();

                // Try to parse the input as an integer
                if (int.TryParse(userInput, out int userGuess))
                {
                    numberOfTries++;

                    if (userGuess < 1 || userGuess > 20)
                    {
                        Console.WriteLine("Please guess a number between 1 and 20.");
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        hasGuessedCorrectly = true;
                        Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {numberOfTries} tries.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }

}

