namespace DesignPatterns.Memento;

public class Guess : IComparable<Guess>, IEquatable<Guess>
{
    public char Letter { get; }

    public Guess(char character)
    {
        if (!char.IsLetter(character))
        {
            throw new InvalidGuessException(character);
        }

        Letter = char.ToUpper(character);
    }

    public override int GetHashCode() => Letter.GetHashCode();

    public int CompareTo(Guess? other)
    {
        if (other is null)
            return 1;

        return Letter.CompareTo(other.Letter);
    }

    public bool Equals(Guess? other)
    {
        if (other is null)
            return false;

        return Letter.Equals(other.Letter);
    }
}
