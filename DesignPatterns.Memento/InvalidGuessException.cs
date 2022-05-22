namespace DesignPatterns.Memento;

public class InvalidGuessException : Exception
{
    public InvalidGuessException(char character) 
        : base($"Invalid character: '{character}'. A guess can only be a letter")
    { }
}
