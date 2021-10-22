namespace DesignPatterns.State
{
    public class PlayingState : AudioPlayerState
    {
        public PlayingState(AudioPlayer audioPlayer) : base(audioPlayer)
        {
        }

        public override void Next()
        {
            Console.WriteLine("Next song");
        }

        public override void PressEnterKey()
        {
            Console.WriteLine("Stopped");
            AudioPlayer.ChangeState(new PausedState(AudioPlayer));
        }

        public override void Previous()
        {
            Console.WriteLine("Previous song");
        }
    }
}
