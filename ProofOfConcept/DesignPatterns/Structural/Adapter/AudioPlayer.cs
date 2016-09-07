using System;

namespace ProofOfConcept.DesignPatterns.Structural.Adapter
{
    class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;

        public void Play(AudioType audioType, string fileName)
        {
            if (audioType.Equals(AudioType.MP3)) Console.WriteLine("Playing MP3: " + fileName);
            else if (audioType.Equals(AudioType.VLC) || audioType.Equals(AudioType.MP4))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else Console.WriteLine("Invalid media! " + audioType + " format not supported!");
        }
    }
}
