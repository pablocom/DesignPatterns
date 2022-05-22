using DesignPatterns.Memento;

var game = new HangmanGameCaretaker();

while (!game.HasBeenCompleted())
{
    game.PrintState();
    Console.WriteLine("Enter new guess (A-Z or '-' to undo):");

    var key = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (key == '-')
    {
        game.UndoLastPlay();
        continue;
    }

    game.Guess(key);
}
