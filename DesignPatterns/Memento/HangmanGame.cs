using System.Text;

namespace DesignPatterns.Memento;

internal class HangmanGame
{
    private readonly string _wordToGuess;

    private int _guessesLeft = 6;
    private GuessCollection _guesses = new GuessCollection();

    internal HangmanGame(string wordToGuess)
    {
        _wordToGuess = wordToGuess;
    }

    internal void Guess(Guess guess)
    {
        if (_guessesLeft == 0)
            throw new Exception("Game lost!");

        _guesses.Add(guess);

        if (!_wordToGuess.Contains(guess.Letter))
            _guessesLeft--;
    }

    internal void ResumeFrom(HangmanMemento memento)
    {
        _guessesLeft = memento.GuessesLeft;
        _guesses = memento.Guesses.CreateCopy();
    }

    internal HangmanMemento CreateMemento() => new HangmanMemento(_guessesLeft, _guesses.CreateCopy());

    internal bool IsCompleted()
    {
        return _guesses.ContainsAllLettersIn(_wordToGuess);
    }

    internal void PrintState()
    {
        var sb = new StringBuilder();
        foreach (var letter in _wordToGuess)
        {
            if (_guesses.Contains(new Guess(letter)))
                sb.Append(letter);
            else
                sb.Append('_');
        }

        Console.WriteLine(sb.ToString());
        Console.WriteLine($"Guesses Left: {_guessesLeft}");
        Console.WriteLine($"Guesses: {string.Join(',', _guesses.OrderedAlphabetically.Select(x => x.Letter))}");
    }
}
