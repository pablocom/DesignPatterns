namespace DesignPatterns.State;

public class PausedState : AudioPlayerState
{
    public PausedState(AudioPlayer audioPlayer) : base(audioPlayer)
    {    }

    public override void Next()
    {
        Console.WriteLine("Reproducing next song");
        AudioPlayer.ChangeState(new PlayingState(AudioPlayer));
    }

    public override void PressEnterKey()
    {
        Console.WriteLine("Playing current song");
        AudioPlayer.ChangeState(new PlayingState(AudioPlayer));
    }

    public override void Previous()
    {
        Console.WriteLine("Starting current song from the top");
        AudioPlayer.ChangeState(new PlayingState(AudioPlayer));
    }

}
