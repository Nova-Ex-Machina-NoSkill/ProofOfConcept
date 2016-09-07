namespace ProofOfConcept.DesignPatterns.Structural
{
    using Adapter;
    public class AdapterDemo
    {
        private static AudioPlayer audioPlayer;

        static AdapterDemo()
        {
            audioPlayer = new AudioPlayer();
        }

        public static void TestAdapter()
        {
            audioPlayer.Play(AudioType.MP4, "Please hire me.mp4");
            audioPlayer.Play(AudioType.VLC, "Before the September Ends.vlc");
            audioPlayer.Play(AudioType.MP3, "Lets see if u ever see it.mp3");
        }
    }
}