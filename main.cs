// See https://aka.ms/new-console-template for more information

using hangman;

string quoteToGuess = "hello";
char[] dashedQuote = new string('_', quoteToGuess.Length).ToCharArray();

int life = 0;
List<char> alreadyEntered = new List<char>();


while (true)
{
   HangmanUtils.DisplayMainFrame(alreadyEntered, life, dashedQuote);
    char letter = Console.ReadKey().KeyChar;
    alreadyEntered.Add(letter);
    if (quoteToGuess.Contains(letter))
    {
        for (int i = 0; i < dashedQuote.Length; i++)
        {
            if (quoteToGuess[i] == letter)
            {
                dashedQuote[i] = letter;
            }
        }
        Console.WriteLine(dashedQuote);
    }
    
    
}