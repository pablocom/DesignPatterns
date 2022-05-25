using System.Text;

namespace DesignPatterns.Memento;

internal class HangmanGame
{
    private readonly string _wordToGuess;

    private int guessesLeft = 6;
    private GuessCollection guesses = new GuessCollection();

    internal HangmanGame(string wordToGuess)
    {
        _wordToGuess = wordToGuess;
    }

    internal void Guess(Guess guess)
    {
        if (guessesLeft == 0)
            throw new Exception("Game lost!");

        guesses.Add(guess);

        if (!_wordToGuess.Contains(guess.Letter))
            guessesLeft--;
    }

    internal void ResumeFrom(HangmanMemento memento)
    {
        guessesLeft = memento.GuessesLeft;
        guesses = memento.Guesses.CreateCopy();
    }

    internal HangmanMemento CreateMemento() => new HangmanMemento(guessesLeft, guesses.CreateCopy());

    internal bool IsCompleted()
    {
        return guesses.ContainsAllLettersIn(_wordToGuess);
    }

    internal void PrintState()
    {
        var sb = new StringBuilder();
        foreach (var letter in _wordToGuess)
        {
            if (guesses.Contains(new Guess(letter)))
                sb.Append(letter);
            else
                sb.Append('_');
        }

        Console.WriteLine(sb.ToString());
        Console.WriteLine($"Guesses Left: {guessesLeft}");
        Console.WriteLine($"Guesses: {string.Join(',', guesses.OrderedAlphabetically.Select(x => x.Letter))}");
    }
}
