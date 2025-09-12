using hangman;

string wordToGuess =  "";
try
{
   wordToGuess = HangmanUtils.WordPicker();
}
catch (FileNotFoundException)
{
    Console.WriteLine("⚠️ Error: Could not start the game.");
    Console.WriteLine("Reason: The word list file 'wordlist.txt' is missing.");
    Environment.Exit(1);
}

char[] dashedWord = new string('_', wordToGuess.Length).ToCharArray();

int attempts = 0;
List<char> alreadyEntered = new List<char>();


while (true)
{
    Console.Clear();
    HangmanUtils.DisplayMainFrame(alreadyEntered, attempts, dashedWord);
    
    if (attempts == HangmanUtils.MaxAttempts)
    {
        Console.WriteLine("You lose!");
        break;
    }
    
    if (new string(dashedWord) == wordToGuess)
    {
        Console.WriteLine("You win!");
        break;
    }

    
    Console.Write("Enter a character: ");
    char letter = Console.ReadKey().KeyChar;
    
    if (!char.IsLetter(letter))
    {
        Console.WriteLine("\nYou entered an invalid character!\nTry again.");
        Thread.Sleep(2000);
        continue;
    } 
    
    if (alreadyEntered.Contains(letter))
    {
        Console.WriteLine("\n\nYou already typed this character");
        Thread.Sleep(2000);
        continue;
    }
    alreadyEntered.Add(letter);
    if (wordToGuess.Contains(letter))
    {
        for (int i = 0; i < dashedWord.Length; i++)
        {
            if (wordToGuess[i] == letter)
            {
                dashedWord[i] = letter;
            }
        }
        Console.WriteLine(dashedWord);
    }
    else
    {
        attempts++;
    }
    
}