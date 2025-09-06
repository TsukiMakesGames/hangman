namespace hangman;

public static class HangmanUtils
{
    public static void DisplayMainFrame(List<char> chars, int life, char[] dashedQuote)
    {
        Console.WriteLine(HANGMANPICS[life]);
        if (chars.Count > 0)
        {
            Console.WriteLine($"Letters already entered {string.Join(", ", chars)}");
        }
        Console.WriteLine(dashedQuote);
        Console.Write("Enter a character: ");
    }

    static string[] HANGMANPICS =
    [
        @"
    +---+
    |   |
    |
    |
    |
    |
    =========",
        @"
    +---+
    |   |
    O   |
    |
    |
    |
    =========",
        @"
    +---+
    |   |
    O   |
    |   |
    |
    |
    =========",
        @"
    +---+
    |   |
    O   |
    /|   |
    |
    |
    =========",
        @"
    +---+
    |   |
    O   |
    /|\  |
    |
    |
    =========",
        @"
    +---+
    |   |
    O   |
    /|\  |
    /    |
    |
    =========",
        @"
    +---+
    |   |
    O   |
    /|\  |
    / \  |
    |
    ========="
    ];

}