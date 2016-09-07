namespace ProofOfConcept.DesignPatterns.Structural.Adapter
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(AudioType audioType)
        {
            if (audioType.Equals(AudioType.MP4)) advancedMediaPlayer = new Mp4Player();
            else if (audioType.Equals(AudioType.VLC)) advancedMediaPlayer = new VlcPlayer();
            else advancedMediaPlayer = null;
        }

        public void Play(AudioType audioType, string fileName)
        {
            if (audioType.Equals(AudioType.MP4)) advancedMediaPlayer.PlayMp4(fileName);
            else if (audioType.Equals(AudioType.VLC)) advancedMediaPlayer.PlayVlc(fileName);
        }
    }
}
