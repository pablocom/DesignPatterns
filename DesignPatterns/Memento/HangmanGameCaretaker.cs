namespace DesignPatterns.Memento;

public class HangmanGameCaretaker
{
    private readonly Stack<HangmanMemento> _gameHistory = new Stack<HangmanMemento>();
    private readonly HangmanGame _hangmanGame;

    public HangmanGameCaretaker()
    {
        _hangmanGame = new HangmanGame("SECRET");
        _gameHistory.Push(_hangmanGame.CreateMemento());
    }

    public void Guess(char guess)
    {
        _hangmanGame.Guess(new Guess(guess));
        _gameHistory.Push(_hangmanGame.CreateMemento());   
    }

    public void UndoLastPlay()
    {
        if (_gameHistory.Count <= 1)
            return;

        _gameHistory.Pop();
        _hangmanGame.ResumeFrom(_gameHistory.Peek());
    }

    public bool HasBeenCompleted()
    {
        return _hangmanGame.IsCompleted();
    }

    public void PrintState()
    {
        _hangmanGame.PrintState();
    }
}
