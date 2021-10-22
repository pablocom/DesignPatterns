namespace DesignPatterns.State
{
    public class AudioPlayer
    {
        private AudioPlayerState state;

        public AudioPlayer()
        {
            state = new PausedState(this);
        }

        public void ChangeState(AudioPlayerState state)
        {
            this.state = state;
        }

        public void PressEnterKey()
        {
            state.PressEnterKey();
        }

        public void Next()
        {
            state.Next();
        }

        public void Previous()
        {
            state.Previous();
        }
    }
}