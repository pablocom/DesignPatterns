namespace DesignPatterns.Memento;

public sealed class HangmanMemento
{
    internal int GuessesLeft { get; }
    internal IEnumerable<char> Guesses { get; }

    internal HangmanMemento(int guessesLeft, IEnumerable<char> guesses)
    {
        Guesses = guesses;
        GuessesLeft = guessesLeft;
    }
}
