using DesignPatterns.Memento;

var gameHistory = new Stack<HangmanMemento>();
var game = new HangmanGame();

while (!game.IsWordGuessed())
{
    game.PrintState();
    Console.WriteLine("Enter new guess (A-Z or '-' to undo):");

    var key = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (key == '-' && gameHistory.Count > 1)
    {
        gameHistory.Pop();
        game.ResumeFrom(gameHistory.Peek());
        continue;
    }

    if (char.IsLetter(key))
    {
        game.Guess(char.ToUpper(key));
        gameHistory.Push(game.CreateMemento());
    }
}
