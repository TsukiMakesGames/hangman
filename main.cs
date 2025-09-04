// See https://aka.ms/new-console-template for more information

string quoteToGuess = "herlo";
char[] dashedQuote = new string('_', quoteToGuess.Length).ToCharArray();

int life = 5;

while (true)
{
    Console.WriteLine(new string(dashedQuote));
    Console.WriteLine("Insert a letter: ");
    char letter = Console.ReadKey().KeyChar;
    bool containsLetter = quoteToGuess.Contains(letter);
    if (containsLetter)
    {
        for (int i = 0; i < quoteToGuess.Length; i++)
        {
            if (quoteToGuess[i] == letter)
            {
                dashedQuote[i] = quoteToGuess[i];
            }
        }
    }
    else
    {
        life--;
    }

    if (life == 0)
    {
        break;
    }
}