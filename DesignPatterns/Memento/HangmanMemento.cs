namespace DesignPatterns.Memento;

public sealed class HangmanMemento
{
    internal int GuessesLeft { get; }
    internal GuessCollection Guesses { get; }

    internal HangmanMemento(int guessesLeft, GuessCollection guesses)
    {
        Guesses = guesses;
        GuessesLeft = guessesLeft;
    }
}
