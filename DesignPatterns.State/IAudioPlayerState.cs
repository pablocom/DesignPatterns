namespace DesignPatterns.State
{
    public abstract class AudioPlayerState
    {
        protected AudioPlayer AudioPlayer { get; }

        protected AudioPlayerState(AudioPlayer audioPlayer)
        {
            AudioPlayer = audioPlayer;
        }

        public abstract void PressEnterKey();
        public abstract void Next();
        public abstract void Previous();
    }
}
