// See https://aka.ms/new-console-template for more information

using System;
using GuessNum;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Game.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

namespace GuessNum
{
    public static class Game
    {
        public static void Run()
        {
            // Initialize variables
            int numberToGuess = new Random().Next(1, 101);
            int attempts = 0;
            int userGuess = 0;

            // Display game instructions
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("I have randomly chosen a number between 1 and 100.");
            Console.WriteLine("Can you guess what it is?");

            // Loop until the user guesses the correct number
            while (userGuess != numberToGuess)
            {
                // Get user input
                bool isValidInput = false;
                while (!isValidInput)
                {
                    Console.Write($"Attempt #{attempts + 1}: ");
                    string input = Console.ReadLine();

                    // Validate user input
                    if (int.TryParse(input, out userGuess))
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }

                // Check if the user's guess is correct
                attempts++;
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }
        }
    }
}
