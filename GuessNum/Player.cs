namespace GuessNum;

public static class Player
{
    public static int MakeChoice(int maxValue)
    {
        while (true)
        {
            Console.WriteLine($"Type a number between 0 and {maxValue}");
            bool success = int.TryParse(Console.ReadLine(), out int choice);
            if (success && choice >= 0 && choice <= maxValue) 
                return choice;
            else 
                Console.WriteLine("Invalid value!");
        }
    }
}