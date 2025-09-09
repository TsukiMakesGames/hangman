namespace hangman;

using System.IO;

public static class HangmanUtils
{
    public static void DisplayMainFrame(List<char> chars, int attempts, char[] dashedWord)
    {
        Console.WriteLine($"Attempts: {attempts}");
        Console.WriteLine(HANGMANPICS[attempts]);
        if (chars.Count > 0)
        {
            Console.WriteLine($"\nLetters already entered {string.Join(", ", chars)}\n");
        }

        Console.WriteLine(dashedWord);
        Console.WriteLine();

    }

    public static string WordPicker()
    {
        string path = "wordlist.txt";
        
        string[] lines = File.ReadAllLines(path);
        var rand = new Random();
        string word = lines[rand.Next(lines.Length)].Trim();
        Console.WriteLine(word);
        
        return word;
    }

    public static int MAX_ATTEMPTS = 6;
    
    private static string[] HANGMANPICS =
    {
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
    };

};