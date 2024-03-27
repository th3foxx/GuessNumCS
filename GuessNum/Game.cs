namespace GuessNum;

public static class Game
{
    private static readonly Random Random = new Random();
    public static void Run(int maxValue = 30)
    {
        int attempts = 3;
        int guessedNumber = Random.Next(maxValue);
        Console.WriteLine($"The computer guessed a number between 0 and {maxValue}");

        while (attempts != 0) 
        {
            int playerGuess = Player.MakeChoice(maxValue);
            
            if (playerGuess == guessedNumber)
                break;
            else if(playerGuess > guessedNumber) 
                Console.WriteLine($"The number {playerGuess} is greater than what the computer guessed.");
            else if(playerGuess < guessedNumber)
                Console.WriteLine($"The number {playerGuess} is less than what the computer guessed.");
            
            attempts--;
        }

        string result = attempts != 0 ? "You've won!" : "You've lost!";
        Console.WriteLine($"{result}\nThe computer guessed the number {guessedNumber}");
    }
}