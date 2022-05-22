namespace DesignPatterns.Memento;

internal class GuessCollection
{
    private readonly HashSet<Guess> _guesses = new HashSet<Guess>();
    internal IEnumerable<Guess> OrderedAlphabetically => _guesses.OrderBy(x => x);

    public GuessCollection()
    { }

    private GuessCollection(Guess[] guesses)
    {
        _guesses = new HashSet<Guess>(guesses);
    }

    internal void Add(Guess guess)
    {
        if (_guesses.Contains(guess))
            throw new InvalidOperationException("Cannot add a guess that has been already placed");

        _guesses.Add(guess);
    }

    internal bool Contains(Guess guess) => _guesses.Contains(guess);

    internal bool ContainAllLettersIn(string wordToGuess)
    {
        var orderedLettersGuessed = _guesses.OrderBy(x => x).Select(x => x.Letter);
        var orderedDistinctLettersInWord = wordToGuess.Distinct().OrderBy(x => x);

        return Enumerable.SequenceEqual(orderedDistinctLettersInWord, orderedLettersGuessed);
    }

    public GuessCollection CreateCopy()
    {
        return new GuessCollection(_guesses.ToArray());
    }
}
