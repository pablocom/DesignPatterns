using System.Text;

namespace DesignPatterns.Memento;

public class HangmanGame
{
    public int GuessesLeft { get; private set; } = 6;
    public List<char> Guesses { get; private set; } = new List<char>();

    private readonly string _wordToGuess;

    public HangmanGame()
    {
        _wordToGuess = "BATMAN";
    }

    public void Guess(char guess)
    {
        if (Guesses.Contains(guess))
        {
            Console.WriteLine("Cannot guess more than one time the same character");
            return;
        }

        Guesses.Add(guess);

        if (!_wordToGuess.Contains(guess))
            GuessesLeft--;
    }

    public void ResumeFrom(HangmanMemento memento)
    {
        GuessesLeft = memento.GuessesLeft;
        Guesses.Clear();
        Guesses.AddRange(memento.Guesses);
    }

    public HangmanMemento CreateMemento() => new HangmanMemento(GuessesLeft, new List<char>(Guesses));

    public void PrintState()
    {
        var sb = new StringBuilder();
        foreach(var letter in _wordToGuess)
        {
            if (Guesses.Contains(letter))
                sb.Append(letter);
            else
                sb.Append("_");
        }

        Console.WriteLine(sb.ToString());
        Console.WriteLine($"Guesses Left: {GuessesLeft}");
        Console.WriteLine($"Guesses: {string.Join(',', Guesses.OrderBy(x => x))}");
    }

    public bool IsWordGuessed()
    {
        var lettersIsWordOrdered = _wordToGuess.Distinct().OrderBy(x => x);
        var guessesOrdered = Guesses.OrderBy(x => x);

        return Enumerable.SequenceEqual(lettersIsWordOrdered, guessesOrdered);
    }
}
