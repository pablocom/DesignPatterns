using DesignPatterns.State;

var player = new AudioPlayer();
var command = Console.ReadLine();

while (command != "C")
{
    switch (command)
    {
        case "N":
            player.Next();
            break;
        case "P":
            player.Previous();
            break;
        case "E":
            player.PressEnterKey();
            break;
    }

    command = Console.ReadLine();
}

