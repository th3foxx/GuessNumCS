namespace GuessNum;

public class Game
{
    private readonly Random _random = new Random();
    private int _maxValue;

    public Game(int maxValue = 30)
    {
        _maxValue = maxValue;
    }

    public virtual void Run()
    {
        int attempts = 3;
        int guessedNumber = _random.Next(_maxValue);
        Console.WriteLine($"The computer guessed a number between 0 and {_maxValue}");

        while (attempts != 0) 
        {
            if (int.TryParse(Player.MakeChoice(_maxValue, "Enter a number between 0 and {_maxValue}"), out int playerGuess))
            {
                if (playerGuess == guessedNumber)
                {
                    break;
                }
                else if (playerGuess > guessedNumber)
                {
                    Console.WriteLine($"The number {playerGuess} is greater than what the computer guessed.");
                }
                else if (playerGuess < guessedNumber)
                {
                    Console.WriteLine($"The number {playerGuess} is less than what the computer guessed.");
                }

                attempts--;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        string result = attempts != 0 ? "You've won!" : "You've lost!";
        Console.WriteLine($"{result}\nThe computer guessed the number {guessedNumber}");
        Console.WriteLine("Do you want to play again? (y/n)");
        if (Console.ReadLine().ToLower() == "y")
        {
            Run();
        }
    }
}


public static class Player
{
    public static string MakeChoice(int maxValue, string prompt = "Enter a number:")
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}
